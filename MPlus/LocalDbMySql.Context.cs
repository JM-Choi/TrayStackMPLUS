//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MPlus
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MPlusEntities : DbContext
    {
        public MPlusEntities()
            : base("name=MPlusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alarm> alarm { get; set; }
        public virtual DbSet<alarm_define> alarm_define { get; set; }
        public virtual DbSet<alarm_history> alarm_history { get; set; }
        public virtual DbSet<charge> charge { get; set; }
        public virtual DbSet<controller> controller { get; set; }
        public virtual DbSet<cost> cost { get; set; }
        public virtual DbSet<distance> distance { get; set; }
        public virtual DbSet<pepschedule> pepschedule { get; set; }
        public virtual DbSet<pepschedule_history> pepschedule_history { get; set; }
        public virtual DbSet<standby> standby { get; set; }
        public virtual DbSet<unit> unit { get; set; }
        public virtual DbSet<vehicle> vehicle { get; set; }
        public virtual DbSet<vehicle_part> vehicle_part { get; set; }
        public virtual DbSet<zone> zone { get; set; }
    }
}
