//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountManager.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounts
    {
        public Accounts()
        {
            this.Analytics = new HashSet<Analytics>();
        }
    
        public int IdAccount { get; set; }
        public int IdUser { get; set; }
        public int IdCategory { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Analytics> Analytics { get; set; }
    }
}
