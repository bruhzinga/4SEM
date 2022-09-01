using LABA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        public List<Account> _originator;

        public Caretaker(List<Account> originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            this._mementos.Add(new ConcreteMemento(_originator));
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            try
            {
                _originator.Clear();
                _originator.AddRange(memento.GetState());
            }
            catch (Exception)
            {
                this.Undo();
            }
        }
    }
}