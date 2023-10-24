using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class AppViewModel : INotifyPropertyChanged
    {
        #region Конструкторы

        public AppViewModel()
        {
            ClientsList = new ObservableCollection<Client>
            {
                new Client("Михаил", "Смирнов", "Иванович", "5555555", "1102 555555"),
                new Client("Михаил", "Смирнов", "Иванович", "5555555", "1102 555555"),
                new Client("Михаил", "Смирнов", "Иванович", "5555555", "1102 555555")
            };

            this.Consultant = new Consultant();
        }

        #endregion

        #region Поля

        /// <summary>
        /// Поле выбранный клиент
        /// </summary>
        private Client selectedClient;

        /// <summary>
        /// Поле пользователь
        /// </summary>
        private Consultant consultant;

        private string viewPassport = "TTTT";
        #endregion

        #region Свойства

        /// <summary>
        /// Свойство список клиентов
        /// </summary>
        public ObservableCollection<Client> ClientsList { get; set; }

        /// <summary>
        /// Свойство выбранный клиент
        /// </summary>
        public Client SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("ViewPasspor");
                OnPropertyChanged("SelectedClient");
            }
        }

        /// <summary>
        /// Свойство пользователь
        /// </summary>
        public Consultant Consultant 
        { 
            get { return consultant; }
            set 
            {
                consultant = value;
                OnPropertyChanged("Consultant");
            }
        }

        public string ViewPassport
        {
            get { return viewPassport; }
            set 
            {
                if (viewPassport != value)
                {
                    viewPassport = value;
                    OnPropertyChanged("ViewPasspor");
                    OnPropertyChanged("VisiblePassport");
                }
            }
        }

        public string VisiblePassport
        {
            get { return GetVisiblePassport(); }
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

        private string GetVisiblePassport()
        {
            string visiblePassport = string.Empty;

            foreach(char c in SelectedClient.Passport)
                visiblePassport += "*";

            return visiblePassport;
        }

        #endregion
    }
}
