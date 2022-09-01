using LABA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public interface IMemento
    {
        List<Account> GetState();

        DateTime GetDate();
    }

    internal class ConcreteMemento : IMemento
    {
        private List<Account> _state;

        private DateTime _date;

        public ConcreteMemento(List<Account> state)
        {
            this._state = new List<Account>(state);
            this._date = DateTime.Now;
        }

        // Создатель использует этот метод, когда восстанавливает своё
        // состояние.
        public List<Account> GetState()
        {
            return this._state;
        }

        // Остальные методы используются Опекуном для отображения метаданных.

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}