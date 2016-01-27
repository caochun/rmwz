using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Raven.Client;
using Raven.Client.Linq;

namespace BLL
{
    public class PersonBLL
    {
        private PersonDAO persondao=new PersonDAO();
        private IDocumentStore docStore= ConnectDB.createstore();
        public bool add(Person person ,out string message) {
            message = "";
            bool issucess = false;
            if (person.LastName == "")
            {
                message = "LastName不能为空";

            }
            else if (person.FirstName == "") {
                message = "FirstName不能为空";
            }
            else {
                persondao.add(person);
                issucess = true;
                message = "添加成功";
            }

            return issucess;
        }
        public bool delete(String personID, out  string message) {
            message = "";
            bool issucess = false;
            if (personID == "")
            {
                message = "请选择要删除的用户数据";
            }
            else {
                persondao.delete(personID);
                issucess = true;
                message = "删除成功";
            }
            return issucess;
        }
        public bool update(string personID,string LastName,string FirstName, out  string message) {
            message = "";
            bool issucess = false;
            using (var session = docStore.OpenSession())
            {
                if (personID == "")
                {
                    message = "请输入ID";
                }
                else if (session.Load<Person>(personID) == null)
                {
                    message = "ID不存在，请重新输入";
                }
                else if (LastName == "" || FirstName == "") {
                    message = "更新失败，LastName或FirstName不能为空";
                }
                else {
                    persondao.update(personID, LastName, FirstName);
                    issucess = true;
                    message = "更新成功";
                }
            }
            return issucess;
        }
        public bool getinfo(string personID, out string message) {
            message = "";
            bool issucess=true;
            //IRavenQueryable<Person> p;
            using (var session = docStore.OpenSession()) {
                if (personID == "")
                {
                    message = "请输入ID";
                    issucess = false;
                     //p = session.Query<Person>();
                }
                else if (session.Load<Person>(personID) == null)
                {
                    message = "ID不存在，请重新输入";
                    issucess = false;
                    // p = session.Query<Person>();
                }
                return issucess;

            }   
        }
        

    }
}
