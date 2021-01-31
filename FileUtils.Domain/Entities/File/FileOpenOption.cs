using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtils.Domain.Entities.File
{
    /// <summary>
    /// ファイルオープンする際に必要なオプションパラメータをまとめたクラス
    /// </summary>
    public sealed class FileOpenOption
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mode">モード</param>
        /// <param name="access">アクセス</param>
        public FileOpenOption(FileMode mode, FileAccess access)
        {
            this.Mode = mode;
            this.Access = access;
        }

        /// <summary>
        /// モード
        /// </summary>
        public FileMode Mode { get; }

        /// <summary>
        /// アクセス
        /// </summary>
        public FileAccess Access { get; }

    }
}
