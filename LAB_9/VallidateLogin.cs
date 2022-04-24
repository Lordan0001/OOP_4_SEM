using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rock_shop
{

    class VallidateLogin : ObservableObject
    {
        private string _username;
        private int _password;

        [Required(ErrorMessage = "Заполните поле")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Миниму 5 символов")]
        public string Username
        {
            get { return _username; }
            set
            {
                ValidateProperty(value, "Username");
                OnPropertyChanged(ref _username, value);
            }
        }
        [Required(ErrorMessage = "Заполните поле")]
        [Range(1, 9999, ErrorMessage = "****")]
        public int Password
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
