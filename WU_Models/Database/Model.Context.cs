﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WU_Models.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Univercity02Entities : DbContext
    {
        public Univercity02Entities()
            : base("name=Univercity02Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CertificateClass> CertificateClasses { get; set; }
        public virtual DbSet<DegreeProgram> DegreePrograms { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<StudentTest> StudentTests { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    
        public virtual ObjectResult<SP_CertificateClass_Get_all_Result> SP_CertificateClass_Get_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CertificateClass_Get_all_Result>("SP_CertificateClass_Get_all");
        }
    
        public virtual ObjectResult<SP_CertificateClass_Get_By_Id_Result> SP_CertificateClass_Get_By_Id(Nullable<long> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CertificateClass_Get_By_Id_Result>("SP_CertificateClass_Get_By_Id", classidParameter);
        }
    
        public virtual ObjectResult<SP_CheckLogin_Result> SP_CheckLogin(string userName, string passWord)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CheckLogin_Result>("SP_CheckLogin", userNameParameter, passWordParameter);
        }
    
        public virtual int SP_Delete_Account(Nullable<System.Guid> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Account", useridParameter);
        }
    
        public virtual int SP_Delete_Student(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Delete_Student", studentIdParameter);
        }
    
        public virtual ObjectResult<SP_Get_Account_all_Result> SP_Get_Account_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Account_all_Result>("SP_Get_Account_all");
        }
    
        public virtual ObjectResult<SP_Get_CertificateClass_Result> SP_Get_CertificateClass()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_CertificateClass_Result>("SP_Get_CertificateClass");
        }
    
        public virtual ObjectResult<SP_Get_Professor_Result> SP_Get_Professor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Professor_Result>("SP_Get_Professor");
        }
    
        public virtual ObjectResult<SP_Get_Professor_By_Id_Result> SP_Get_Professor_By_Id(Nullable<int> professorId)
        {
            var professorIdParameter = professorId.HasValue ?
                new ObjectParameter("ProfessorId", professorId) :
                new ObjectParameter("ProfessorId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Professor_By_Id_Result>("SP_Get_Professor_By_Id", professorIdParameter);
        }
    
        public virtual ObjectResult<SP_Get_Student_Classes_all_Result> SP_Get_Student_Classes_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Student_Classes_all_Result>("SP_Get_Student_Classes_all");
        }
    
        public virtual ObjectResult<SP_Get_Student_Classes_by_ClassId_Result> SP_Get_Student_Classes_by_ClassId(Nullable<int> classId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Get_Student_Classes_by_ClassId_Result>("SP_Get_Student_Classes_by_ClassId", classIdParameter);
        }
    
        public virtual int SP_Insert_Account(Nullable<System.Guid> userid, string username, string password, string email, string mobile, string description)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(System.Guid));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_Account", useridParameter, usernameParameter, passwordParameter, emailParameter, mobileParameter, descriptionParameter);
        }
    
        public virtual int SP_Insert_Student(Nullable<int> studentId, string studenName, Nullable<int> programId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var studenNameParameter = studenName != null ?
                new ObjectParameter("StudenName", studenName) :
                new ObjectParameter("StudenName", typeof(string));
    
            var programIdParameter = programId.HasValue ?
                new ObjectParameter("ProgramId", programId) :
                new ObjectParameter("ProgramId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_Student", studentIdParameter, studenNameParameter, programIdParameter);
        }
    
        public virtual int SP_Update_Account(Nullable<System.Guid> userid, string username, string password, string email, string mobile, string description)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(System.Guid));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Account", useridParameter, usernameParameter, passwordParameter, emailParameter, mobileParameter, descriptionParameter);
        }
    
        public virtual int SP_Update_Student(Nullable<int> studentId, string studenName, Nullable<int> programId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var studenNameParameter = studenName != null ?
                new ObjectParameter("StudenName", studenName) :
                new ObjectParameter("StudenName", typeof(string));
    
            var programIdParameter = programId.HasValue ?
                new ObjectParameter("ProgramId", programId) :
                new ObjectParameter("ProgramId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Update_Student", studentIdParameter, studenNameParameter, programIdParameter);
        }
    
        public virtual ObjectResult<SP_Accounts_getPaging_Result> SP_Accounts_getPaging(Nullable<int> start, Nullable<int> length)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var lengthParameter = length.HasValue ?
                new ObjectParameter("length", length) :
                new ObjectParameter("length", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Accounts_getPaging_Result>("SP_Accounts_getPaging", startParameter, lengthParameter);
        }
    
        public virtual ObjectResult<SP_Accounts_paging_getEmail_Result> SP_Accounts_paging_getEmail(string keyString, Nullable<int> start, Nullable<int> length)
        {
            var keyStringParameter = keyString != null ?
                new ObjectParameter("KeyString", keyString) :
                new ObjectParameter("KeyString", typeof(string));
    
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var lengthParameter = length.HasValue ?
                new ObjectParameter("length", length) :
                new ObjectParameter("length", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Accounts_paging_getEmail_Result>("SP_Accounts_paging_getEmail", keyStringParameter, startParameter, lengthParameter);
        }
    }
}
