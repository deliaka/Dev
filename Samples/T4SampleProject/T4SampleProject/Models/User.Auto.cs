using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using T4SampleProject;
using T4SampleProject.ComponentModel;
using T4SampleProject.DataAnotations;

namespace T4SampleProject.Models
{
    /// <summary>
    /// ユーザー情報を提供する。
    /// </summary>
    /// <remarks>
    /// このファイルはT4テンプレートによって自動生成されたファイルです。
    /// このファイルを編集すると、アプリケーションの動作に影響をあたえる可能性があります。
    /// </remarks>
    /// <auto-generate />
    public partial class User : BindableBase
    {
        #region 定数

        /// <summary>個人が保持できるアドレスの最大数</summary>
        public const int AddressMaxCount = 10;

        #endregion //定数

        #region メンバ

        /// <summary>ユーザーID</summary>
        private int _iD;

        /// <summary>ユーザー名</summary>
        private string _name;

        /// <summary>誕生日</summary>
        private DateTime _birthday;

        /// <summary>ユーザーが保持するメールアドレスリスト</summary>
        private ObservableCollection<string> _mailAddresses = new ObservableCollection<string>();

        /// <summary>ユーザーの性別</summary>
        private GenderType _gender;

        #endregion //メンバ

        #region プロパティ

        /// <summary>ユーザーID</summary>
        [Display(Name = "ユーザーID")]
        [RangeCustom(typeof(int), "0", "100")]
        public int ID
        {
            get { return _iD; }
            set { SetProperty<int>(ref _iD, value); }
        }

        /// <summary>ユーザー名</summary>
        [Display(Name = "ユーザー名")]
        [RequiredCustom()]
        [StringLengthCustom(0, 0)]
        public string Name
        {
            get { return _name; }
            set { SetProperty<string>(ref _name, value); }
        }

        /// <summary>誕生日</summary>
        [Display(Name = "誕生日")]
        [RangeCustom(typeof(DateTime), "2000/01/01 0:00:00", "2020/12/31 0:00:00")]
        public DateTime Birthday
        {
            get { return _birthday; }
            set { SetProperty<DateTime>(ref _birthday, value); }
        }

        /// <summary>ユーザーが保持するメールアドレスリスト</summary>
        [Display(Name = "メールアドレス")]
        public ObservableCollection<string> MailAddresses
        {
            get { return _mailAddresses; }
            set { SetProperty<ObservableCollection<string>>(ref _mailAddresses, value); }
        }

        /// <summary>ユーザーの性別</summary>
        [Display(Name = "性別")]
        public GenderType Gender
        {
            get { return _gender; }
            set { SetProperty<GenderType>(ref _gender, value); }
        }

        #endregion //プロパティ
    }
}
