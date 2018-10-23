using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS
{
    public class EmployeeDTO
    {
        private string username, password, fullname, gender, role, createBy, lastModifiedBy;
        private DateTime birthDate, createOn, lastModifiedOn;
        private int isActive;

        public EmployeeDTO()
        {

        }

        public EmployeeDTO(string username, string password, string fullname, string gender, string role, string createBy, string lastModifiedBy, DateTime birthDate, DateTime createOn, DateTime lastModifiedOn, int isActive)
        {
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.gender = gender;
            this.role = role;
            //this.picture = picture;
            this.createBy = createBy;
            this.lastModifiedBy = lastModifiedBy;
            this.birthDate = birthDate;
            this.createOn = createOn;
            this.lastModifiedOn = lastModifiedOn;
            this.isActive = isActive;
        }
        public string getUsername()
        {
            return username;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public String getFullname()
        {
            return fullname;
        }

        public void setFullname(string fullname)
        {
            this.fullname = fullname;
        }

        public string getGender()
        {
            return gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getRole()
        {
            return role;
        }

        public void setRole(string role)
        {
            this.role = role;
        }
       

        public string getCreateBy()
        {
            return createBy;
        }

        public void setCreateBy(string createBy)
        {
            this.createBy = createBy;
        }

        public string getLastModifiedBy()
        {
            return lastModifiedBy;
        }

        public void setLastModifiedBy(string lastModifiedBy)
        {
            this.lastModifiedBy = lastModifiedBy;
        }

        public DateTime getBirthDate()
        {
            return birthDate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public DateTime getCreateOn()
        {
            return createOn;
        }

        public void setCreateOn(DateTime createOn)
        {
            this.createOn = createOn;
        }

        public DateTime getLastModifiedOn()
        {
            return lastModifiedOn;
        }

        public void setLastModifiedOn(DateTime lastModifiedOn)
        {
            this.lastModifiedOn = lastModifiedOn;
        }

        public int getIsActive()
        {
            return isActive;
        }

        public void setIsActive(int isActive)
        {
            this.isActive = isActive;
        }

    }
}
