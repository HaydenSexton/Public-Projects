using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Letter
    {
        protected string _recipient;
        protected DateTime _sentDate;

        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        public override string ToString()
        {
            return $"{SentDate.ToString("dMMMyyyy")}, {Recipient}, ${Price:F2}";
        }

        public string Recipient
        {
            get { return _recipient; }
        }
        public DateTime SentDate
        {
            get { return _sentDate; }
        }
        public virtual double Price
        {
            get { return 0.5; }
        }
    }
}
