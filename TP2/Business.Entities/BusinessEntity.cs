using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int Id;
        private States _State;
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
        public int ID
        {
            get
            { 
                return Id; 
            }
            set
            { 
                Id = value;
            }
        }
        public States State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
            }
        }
    }
}
