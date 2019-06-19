using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcadFinalProjectCodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Data (In this case fake data)
            List<Contact> contactList = FakeData.GetContacts();

            //traverse and insert data into database.
            using (ContactDbContext db = new ContactDbContext())
            {
                //Insert
                foreach(Contact contact in contactList)
                {
                    db.Contacts.Add(contact);
                    db.SaveChanges();
                }

                //Read the data back from the db
                List<Contact> DbContactList = db.Contacts.Include("ContactNumbers").ToList();

                foreach(Contact contact in DbContactList)
                {
                    Console.WriteLine("Contact: {0} {1}  email:{2}", contact.FirstName, contact.LastName, contact.Email);
                    foreach(ContactNumber num in contact.ContactNumbers)
                    {
                        Console.WriteLine("   Type: {0}  Num: {1}", num.Type, num.Number);                        
                    }
                }

                //Update 1
                Contact con = DbContactList.First();
                con.FirstName = "First Name";
                con.LastName = "Last Name";
                db.SaveChanges();

                DbContactList = db.Contacts.ToList();  //Only contacts necessary to see updated data
                con = DbContactList.First();
                Console.Write("Updated Contact: {0} {1}", con.FirstName, con.LastName);

            }

            Console.ReadLine();//Pause the output
        }
    }
}
