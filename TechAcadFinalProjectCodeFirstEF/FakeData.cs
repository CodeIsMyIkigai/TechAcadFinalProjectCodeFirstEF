using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Normally in an application when you are getting data to insert into a program you would have it in some sort of file
 already.  However as the project requirements said to make this project as simple as possible I've created them here
 already consumed and inserted inth the data model format.

Fake data generated from various freely avialable websites.

 */

namespace TechAcadFinalProjectCodeFirstEF
{
    public class FakeData
    {
        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();

            List<ContactNumber> contactNumbers = new List<ContactNumber>
            {
                new ContactNumber() { Id = 0, Type = "Home", Number = "(828) 886-4679" },
                new ContactNumber() { Id = 0, Type = "Cell", Number = "(429) 856-4898" },
                new ContactNumber() { Id = 0, Type = "Work", Number = "(661) 267-7922" },
                new ContactNumber() { Id = 1, Type = "Home", Number = "(923) 585-4527" },
                new ContactNumber() { Id = 1, Type = "Cell", Number = "(837) 219-3464" },
                new ContactNumber() { Id = 1, Type = "Work", Number = "(780) 933-7106" },
                new ContactNumber() { Id = 2, Type = "Home", Number = "(341) 245-8861" },
                new ContactNumber() { Id = 2, Type = "Cell", Number = "(451) 244-1478" },
                new ContactNumber() { Id = 2, Type = "Work", Number = "(989) 946-6763" },
                new ContactNumber() { Id = 3, Type = "Home", Number = "(870) 958-5995" },
                new ContactNumber() { Id = 3, Type = "Cell", Number = "(798) 861-3156" },
                new ContactNumber() { Id = 3, Type = "Work", Number = "(504) 911-3911" },
                new ContactNumber() { Id = 4, Type = "Home", Number = "(851) 243-9600" },
                new ContactNumber() { Id = 4, Type = "Cell", Number = "(995) 632-3930" },
                new ContactNumber() { Id = 4, Type = "Work", Number = "(323) 609-6427" },
                new ContactNumber() { Id = 5, Type = "Home", Number = "(202) 862-4321" },
                new ContactNumber() { Id = 5, Type = "Cell", Number = "(753) 415-7819" },
                new ContactNumber() { Id = 5, Type = "Work", Number = "(784) 850-9719" },
                new ContactNumber() { Id = 6, Type = "Home", Number = "(862) 643-1812" },
                new ContactNumber() { Id = 6, Type = "Cell", Number = "(305) 635-4601" },
                new ContactNumber() { Id = 6, Type = "Work", Number = "(518) 632-9293" },
                new ContactNumber() { Id = 7, Type = "Home", Number = "(298) 897-7498" },
                new ContactNumber() { Id = 7, Type = "Cell", Number = "(909) 780-9178" },
                new ContactNumber() { Id = 7, Type = "Work", Number = "(308) 265-6179" },
                new ContactNumber() { Id = 8, Type = "Home", Number = "(686) 446-0721" },
                new ContactNumber() { Id = 8, Type = "Cell", Number = "(715) 389-6894" },
                new ContactNumber() { Id = 8, Type = "Work", Number = "(389) 616-2521" },
                new ContactNumber() { Id = 9, Type = "Home", Number = "(861) 495-9479" },
                new ContactNumber() { Id = 9, Type = "Cell", Number = "(357) 210-6142" },
                new ContactNumber() { Id = 9, Type = "Work", Number = "(580) 775-2210" },
                new ContactNumber() { Id = 10, Type = "Home", Number = "(387) 579-8722" },
                new ContactNumber() { Id = 10, Type = "Cell", Number = "(614) 639-3774" },
                new ContactNumber() { Id = 10, Type = "Work", Number = "(365) 469-9775" },
                new ContactNumber() { Id = 11, Type = "Home", Number = "(521) 474-0861" },
                new ContactNumber() { Id = 11, Type = "Cell", Number = "(201) 875-8512" },
                new ContactNumber() { Id = 11, Type = "Work", Number = "(565) 903-2901" },
                new ContactNumber() { Id = 12, Type = "Home", Number = "(426) 370-6067" },
                new ContactNumber() { Id = 12, Type = "Cell", Number = "(299) 776-0813" },
                new ContactNumber() { Id = 12, Type = "Work", Number = "(431) 671-6734" },
                new ContactNumber() { Id = 13, Type = "Home", Number = "(505) 610-6700" },
                new ContactNumber() { Id = 13, Type = "Cell", Number = "(546) 733-3080" },
                new ContactNumber() { Id = 13, Type = "Work", Number = "(668) 369-7740" },
                new ContactNumber() { Id = 14, Type = "Home", Number = "(905) 758-9081" },
                new ContactNumber() { Id = 14, Type = "Cell", Number = "(478) 589-8805" },
                new ContactNumber() { Id = 14, Type = "Work", Number = "(723) 378-4382" },
                new ContactNumber() { Id = 15, Type = "Home", Number = "(611) 382-2202" },
                new ContactNumber() { Id = 15, Type = "Cell", Number = "(828) 237-1890" },
                new ContactNumber() { Id = 15, Type = "Work", Number = "(618) 238-5254" },
                new ContactNumber() { Id = 16, Type = "Home", Number = "(830) 590-0970" },
                new ContactNumber() { Id = 16, Type = "Cell", Number = "(299) 302-3545" },
                new ContactNumber() { Id = 16, Type = "Work", Number = "(385) 614-8583" },
                new ContactNumber() { Id = 17, Type = "Home", Number = "(893) 360-7030" },
                new ContactNumber() { Id = 17, Type = "Cell", Number = "(266) 896-9851" },
                new ContactNumber() { Id = 17, Type = "Work", Number = "(752) 487-4359" },
                new ContactNumber() { Id = 18, Type = "Home", Number = "(528) 324-6530" },
                new ContactNumber() { Id = 18, Type = "Cell", Number = "(345) 669-9710" },
                new ContactNumber() { Id = 18, Type = "Work", Number = "(920) 246-9425" },
                new ContactNumber() { Id = 19, Type = "Home", Number = "(304) 788-4063" },
                new ContactNumber() { Id = 19, Type = "Cell", Number = "(230) 758-1055" },
                new ContactNumber() { Id = 19, Type = "Work", Number = "(851) 588-4900" }
            };


            contacts.Add(new Contact { Id = 0, FirstName = "Clywd", LastName = "Kalinsky", Email = "ckalinskyj@bloomberg.com" });
            contacts.Add(new Contact { Id = 1, FirstName = "Waverley", LastName = "Kneesha", Email = "wkneesha0@addthis.com" });
            contacts.Add(new Contact { Id = 2, FirstName = "Noak", LastName = "Livesey", Email = "nlivesey1@youtu.be" });
            contacts.Add(new Contact { Id = 3, FirstName = "Dennie", LastName = "Odams", Email = "dodams2@is.gd" });
            contacts.Add(new Contact { Id = 4, FirstName = "Bjorn", LastName = "Kilfeder", Email = "bkilfeder3@geocities.jp" });
            contacts.Add(new Contact { Id = 5, FirstName = "Asia", LastName = "Steely", Email = "asteely4@seesaa.net" });
            contacts.Add(new Contact { Id = 6, FirstName = "Alanson", LastName = "California", Email = "acalifornia5@mac.com" });
            contacts.Add(new Contact { Id = 7, FirstName = "Shel", LastName = "Vanne", Email = "svanne6@istockphoto.com" });
            contacts.Add(new Contact { Id = 8, FirstName = "Mitch", LastName = "Ruperto", Email = "mruperto7@ebay.co.uk" });
            contacts.Add(new Contact { Id = 9, FirstName = "Gertruda", LastName = "McKaile", Email = "gmckaile8@mysql.com" });
            contacts.Add(new Contact { Id = 10, FirstName = "Jonas", LastName = "Melesk", Email = "jmelesk9@cbc.ca" });
            contacts.Add(new Contact { Id = 11, FirstName = "Brendon", LastName = "Surcomb", Email = "bsurcomba@gov.uk" });
            contacts.Add(new Contact { Id = 12, FirstName = "Susana", LastName = "Wrotham", Email = "swrothamb@odnoklassniki.ru" });
            contacts.Add(new Contact { Id = 13, FirstName = "Norby", LastName = "Swepstone", Email = "nswepstonec@xrea.com" });
            contacts.Add(new Contact { Id = 14, FirstName = "Findley", LastName = "Goodding", Email = "fgooddingd@gnu.org" });
            contacts.Add(new Contact { Id = 15, FirstName = "Jsandye", LastName = "Esplin", Email = "jespline@alexa.com" });
            contacts.Add(new Contact { Id = 16, FirstName = "Marion", LastName = "Bartholin", Email = "mbartholinf@go.com" });
            contacts.Add(new Contact { Id = 17, FirstName = "Goldia", LastName = "Brockett", Email = "gbrockettg@histats.com" });
            contacts.Add(new Contact { Id = 18, FirstName = "Sig", LastName = "Pol", Email = "spolh@zimbio.com" });
            contacts.Add(new Contact { Id = 19, FirstName = "Cassandra", LastName = "Downham", Email = "cdownhami@abc.net.au" });

            foreach(Contact contact in contacts)
            {
                contact.ContactNumbers = contactNumbers.Where(cn => cn.Id == contact.Id).ToList();
            }

            return contacts;
        }
    }
}
