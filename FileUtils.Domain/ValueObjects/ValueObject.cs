using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtils.Domain.ValueObjects
{
    /// <summary>
    /// バリューオブジェクトの基底クラス
    /// </summary>
    /// <typeparam name="T">T</typeparam>
    public abstract class ValueObject<T>
        where T : ValueObject<T>
    {
        /// <summary>
        /// ==
        /// </summary>
        /// <param name="vo1">左辺</param>
        /// <param name="vo2">右辺</param>
        /// <returns>比較結果</returns>
        public static bool operator ==(
            ValueObject<T> vo1,
            ValueObject<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        /// <summary>
        /// !=
        /// </summary>
        /// <param name="vo1">左辺</param>
        /// <param name="vo2">右辺</param>
        /// <returns>比較結果</returns>
        public static bool operator !=(
            ValueObject<T> vo1,
            ValueObject<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        /// <summary>
        /// base.ToString()
        /// </summary>
        /// <returns>base.ToStringの結果</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// base.GetHashCode()
        /// </summary>
        /// <returns>base.GetHashCodeの結果</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 比較
        /// </summary>
        /// <param name="obj">比較対象</param>
        /// <returns>true:一致、false:一致しない</returns>
        public override bool Equals(object obj)
        {
            var vo = obj as T;
            if (vo == null)
            {
                return false;
            }

            return this.EqualsCore(vo);
        }

        /// <summary>
        /// 比較用。各クラスで実装する。
        /// </summary>
        /// <param name="other">比較するオブジェクト</param>
        /// <returns>true:一致、false:一致しない</returns>
        protected abstract bool EqualsCore(T other);
    }
}
