using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace Contacts
{
    interface IContacts
    {
        bool Insert(string name , string family , string mobile , int age , string address);
        bool Update(int contactid,string name, string family, string mobile, int age, string address);
        bool Delete(int contactid);
        DataTable SelectAll();
        DataTable SelectRow(int contactid);
        DataTable Search(string param); 

    }
}
