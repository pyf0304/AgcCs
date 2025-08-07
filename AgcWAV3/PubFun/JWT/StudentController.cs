using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AGCWA.PubFun
{

    [ApiController]
    [Route("[controller]")]
 
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> StudentList = new List<Student>()
    {
        new Student() {Id = "001", Name = "张三", Sex = "男", Age = 19, Dept = "软件学院"},
        new Student() {Id = "002", Name = "李丽", Sex = "女", Age = 19, Dept = "资环学院"}
    };

        [HttpGet]
        public int Plus(int a, int b)
        {
            return a + b;
        }
        //[HttpGet]
        //public IEnumerable<Student> Get()
        //{
        //    return StudentList;
        //}
        [ApiAuthorize]
        [HttpGet("GetObjLst")]
        public IEnumerable<Student> GetObjLst()
        {
            return StudentList;
        }
        //[NoAuthorize]
        [AllowAnonymous]
        [HttpGet("GetObjLst2")]
        public IEnumerable<Student> GetObjLst2()
        {
            return StudentList;
        }
        [HttpGet, Route("GetByDept/{dept}")]
        public IEnumerable<Student> GetByDept(string dept)
        {
            List<Student> tempList = StudentList.Where(p => p.Dept == dept).ToList();
            return tempList;
        }
        [HttpGet("GetId")]
        public Student Get(string id)
        {
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            return tempList.Count == 1 ? tempList.First() : null;
        }

        [HttpPost("Post")]
        public bool Post([FromBody] Student student)
        {
            if (student == null) return false;
            if (StudentList.Where(p => p.Id == student.Id).ToList().Count > 0) return false;
            StudentList.Add(student);
            return true;
        }

        [HttpPut("Put")]
        public bool Put(string id, [FromBody] Student student)
        {
            if (student == null) return false;
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            if (tempList.Count == 0) return false;
            Student originStudent = tempList[0];
            originStudent.Name = student.Name;
            originStudent.Sex = student.Sex;
            originStudent.Age = student.Age;
            originStudent.Dept = student.Dept;
            return true;
        }

        [HttpDelete("Delete")]
        public bool Delete(string id)
        {
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            if (tempList.Count == 0) return false;
            StudentList.Remove(tempList[0]);
            return true;
        }
    }
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Dept { get; set; }
    }
}
