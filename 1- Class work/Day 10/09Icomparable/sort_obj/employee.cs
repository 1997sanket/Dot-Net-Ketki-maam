using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_obj
{
    public class employee:IComparable
    {
        
        public string Name { get; set; }
        public float Salary { get; set; }

       public int CompareTo(object obj)
        {

            employee temp = obj as employee;
            if (temp != null)
            {
                //if (this.Salary > temp.Salary)
                  //  return 1;
                //if (this.Salary < temp.Salary)
                  //      return -1;
                    //        else
                      //  return 0;
                return this.Salary.CompareTo(temp.Salary);
            }
               else
            throw new ArgumentException("Parameter is not a employee!");
        

           // throw new NotImplementedException();
   
            
            }
        /*public int CompareTo(object obj)
        { 
        employee temp = obj as employee;
            if (temp != null)
            {
                return this.Name.CompareTo(temp.Name);
            }
            else
                throw new ArgumentException("Parameter is not a employee!");
        
        
        
        
        }*/

        }
    
}
