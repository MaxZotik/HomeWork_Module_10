using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Consultant
    {
        #region Конструктор
        /// <summary>
        /// Создание работника
        /// </summary>
        /// <param name="Name">Должность</param>
        public Consultant(string Name = "Консультант")
        {
            this.name = Name;
        }
        #endregion

        #region Поля
        /// <summary>
        /// Поле "Должность"
        /// </summary>
        private string name;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство "Должность"
        /// </summary>
        public string Name 
        {   
            get { return this.name; }
            set { name = value; }
        }
        #endregion
    }
}
