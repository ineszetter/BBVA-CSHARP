using System;

namespace Bancomer.Entities.Request
{
    public class SingleParameter : IParameter
    {
        public String ParameterValue { set; get; }
        public string ParameterName { set; get; }

        public SingleParameter(String name, String value)
        {
            ParameterName = name;
            ParameterValue = value;
        }
    }
}