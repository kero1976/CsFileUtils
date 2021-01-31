using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtils.Domain.ValueObjects
{
    /// <summary>
    /// System.IO.FileModeを使いやすくしたクラス。
    /// </summary>
    public sealed class FileMode : ValueObject<FileMode>
    {
        /// <summary>
        /// CreateNew
        /// </summary>
        public static readonly FileMode CreateNew = new FileMode(1);

        /// <summary>
        /// Create
        /// </summary>
        public static readonly FileMode Create = new FileMode(2);

        /// <summary>
        /// Open
        /// </summary>
        public static readonly FileMode Open = new FileMode(3);

        /// <summary>
        /// OpenOrCreate
        /// </summary>
        public static readonly FileMode OpenOrCreate = new FileMode(4);

        /// <summary>
        /// Truncate
        /// </summary>
        public static readonly FileMode Truncate = new FileMode(5);

        /// <summary>
        /// Append
        /// </summary>
        public static readonly FileMode Append = new FileMode(6);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">値</param>
        public FileMode(int value)
        {
            this.Value = value;
         }

        /// <summary>
        /// 値
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NameJ
        {
            get
            {
                if (this == CreateNew)
                {
                    return "CreateNew";
                }

                if (this == Create)
                {
                    return "Create";
                }

                if (this == Open)
                {
                    return "Open";
                }

                if (this == OpenOrCreate)
                {
                    return "OpenOrCreate";
                }

                if (this == Truncate)
                {
                    return "Truncate";
                }

                if (this == Append)
                {
                    return "Append";
                }

                return "Other";
            }
        }

        /// <summary>
        /// 値の比較
        /// </summary>
        /// <param name="other">比較対象</param>
        /// <returns>true:一致、false:一致しない</returns>
        protected override bool EqualsCore(FileMode other)
        {
            return this.Value == other.Value;
        }
    }
}
