using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task_1
{
    public class Client : INotifyPropertyChanged
    {
        #region Конструкторы

        /// <summary>
        /// Создание клиента
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Patronymic">Отчество</param>
        /// <param name="NumberPhone">Номер телефона</param>
        /// <param name="Passport">Серия, номер паспорта</param>
        public Client(string FirstName, string LastName, string Patronymic, string NumberPhone, string Passport)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.patronymic = Patronymic;
            this.numberPhone = NumberPhone;
            this.passport = Passport;
        }
        #endregion

        #region Поля
        /// <summary>
        /// Поле "Имя"
        /// </summary>
        private string firstName;

        /// <summary>
        /// Поле "Фамилия"
        /// </summary>
        private string lastName;

        /// <summary>
        /// Поле "Отчество"
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Поле "Номер телефона"
        /// </summary>
        private string numberPhone;

        /// <summary>
        /// Поле "Серия, номер паспорта"
        /// </summary>
        private string passport;

        #endregion

        #region Свойства
        /// <summary>
        /// Свойство "Имя"
        /// </summary>
        public string FirstName 
        { 
            get { return this.firstName; } 
            set 
            { 
                this.firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        /// <summary>
        /// Свойство "Фамилия"
        /// </summary>
        public string LastName 
        {
            get { return this.lastName; }
            set 
            {
                this.lastName = value; 
                OnPropertyChanged(nameof(LastName));    
            }
        }

        /// <summary>
        /// Свойство "Отчество"
        /// </summary>
        public string Patronymic 
        {
            get { return this.patronymic; }
            set
            {
                this.patronymic = value; 
                OnPropertyChanged(nameof(Patronymic));
            } 
        }

        /// <summary>
        /// Свойство "Номер телефона"
        /// </summary>
        public string NumberPhone 
        {
            get { return this.numberPhone; } 
            set 
            {
                this.numberPhone = value;
                OnPropertyChanged(nameof(NumberPhone));    
            }
        }

        /// <summary>
        /// Свойство "Серия, номер паспорта"
        /// </summary>
        public string Passport 
        {
            get { return this.passport; }
            set
            {
                this.passport = value;
                OnPropertyChanged(nameof(Passport));    
            }
        }

        #endregion

        #region Событие

        /// <summary>
        /// Событие возникает при изменении свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Методы

        /// <summary>
        /// Метод вызывается в свойстве средством доступа Set при изменении свойства
        /// </summary>
        /// <param name="propertyName">Название свойства вызвавшего метод</param>
        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
