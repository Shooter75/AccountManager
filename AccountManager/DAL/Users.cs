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
    
    public partial class Users
    {
        public Users()
        {
            this.Accounts = new HashSet<Accounts>();
        }
    
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    
        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
