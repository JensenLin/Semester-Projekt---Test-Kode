//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PIFilePath
    {
        public PIFilePath()
        {
            this.PIMusikDatas = new HashSet<PIMusikData>();
        }
    
        public string UUIDPath { get; set; }
        public string FilePath { get; set; }
        public string Device_UUIDDevice { get; set; }
    
        public virtual PIDevice PIDevice { get; set; }
        public virtual ICollection<PIMusikData> PIMusikDatas { get; set; }
    }
}