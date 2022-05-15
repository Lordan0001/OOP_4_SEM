using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchingViewsMVVM.Views
{
    public class VallidateLogin : ObservableObject
    {
        //private string _username;
        private long _password;

/*        [Required(ErrorMessage = "Заполните поле")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Миниму 5 символов")]
        public string Username
        {
            get { return _username; }
            set
            {
                ValidateProperty(value, "Username");
                OnPropertyChanged(ref _username, value);
            }
        }*/
      //  [Required(ErrorMessage = "Заполните поле")]
        [Range(1, 15000000, ErrorMessage = "Введены лишние цифры")]
        public long Password
        {
            get { return _password; }
            set
            {
                ValidateProperty(value, "Password");
                OnPropertyChanged(ref _password, value);
            }
        }

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }

    }
}
