using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Model
{
    public class DAL
    {
        StudentEntities con;
        public DAL(StudentEntities con)
        {
            this.con = con;
        }

        public List<Student> Display()
        {
            List<Student> ls = con.students.ToList();
            return ls;
        }
        public void Register(Student obj)
        {
            con.students.Add(obj);
            con.SaveChanges();
        }
        public void Update(int roll_no,Student obj)
        {
            obj.roll_no = roll_no;
            Student obj1 = con.students.Find(obj.roll_no);

            //obj1.roll_no = obj.roll_no;
            obj1.first_name = obj.first_name;
            obj1.last_name = obj.last_name;       
            obj1.standard = obj.standard;
            obj1.contact_no = obj.contact_no;

            con.SaveChanges();
        }
        public void Delete(int roll_no)
        {
            Student obj = con.students.Find(roll_no);
            con.students.Remove(obj);
            con.SaveChanges();
        }
    }
}
