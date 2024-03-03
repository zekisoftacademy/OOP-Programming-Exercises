using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Employees
{
    public class Calisan
    {
        public string name;
        public string Surname;
        public string IdentityNo;
        public decimal Salary;
        public DateTime RegistrationDate;

        public void Create(Calisan yeni)
        {

        }

        decimal PaySalary()
        {
            return 0;
        }

        public void Delete(Calisan kov,ListBox listbox)
        {
            listbox.Items.Remove(listbox.SelectedItem);
        }


    }
}
