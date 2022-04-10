using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_T1
{
    public class NewBornsData
    {
        public String numeC;
        public String prenC;
        public DateTime dataN;
        public String judet;
        public String local;
        public String sex;
        public String numeT;
        public String prenT;
        public String numeM;
        public String prenM;

        public NewBornsData(string numeC, string prenC, DateTime dataN, string judet, string local, string sex, string numeT, string prenT, string numeM, string prenM)
        {
            this.numeC = numeC;
            this.prenC = prenC;
            this.dataN = dataN;
            this.judet = judet;
            this.local = local;
            this.sex = sex;
            this.numeT = numeT;
            this.prenT = prenT;
            this.numeM = numeM;
            this.prenM = prenM;
        }
    }
}
