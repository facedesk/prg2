using System;

namespace prg2._3_design_patterns
{
    public class Decorator{}
    public class NameBank
    {
        public NameBank()
        {
            
        }
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string NameUpper
        {
            get
            {
                return _name.ToUpper();
            }
        }
        public string First
        {
            get
            {
                return _name.Split(' ')[0];
            }
        }
        public string Last
        {
            get
            {
                return names[names.Length - 1];
            }
        }
        private string[] names
        {
            get
            {
                return _name.Split(' ');
            }
        }
        public string Middle
        {
            get
            {
                string middle = "";
                for(int i = 0; i < names.Length ;i++)
                {
                    if(i==0 || i==names.Length -1)
                    {
                        ;
                    }
                    else
                    {
                        middle += names[i];
                    }
                } 
                return middle;
            }
        }
    }
}