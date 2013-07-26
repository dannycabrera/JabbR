using System.Data.Entity.ModelConfiguration;

namespace JabbR.Models.Mapping
{
    public class ChatClientMap : EntityTypeConfiguration<ChatClient>
    {
        public ChatClientMap()
        {
            // Primary Key
            this.HasKey(c => c.Key);

            // Properties
            // Table & Column Mappings
            this.ToTable("ChatClients");
            this.Property(c => c.Key).HasColumnName("Key");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.UserKey).HasColumnName("User_Key");
            this.Property(c => c.UserAgent).HasColumnName("UserAgent");
            this.Property(c => c.Name).HasColumnName("Name");
            this.Property(c => c.LastActivity).HasColumnName("LastActivity");
            this.Property(c => c.LastClientActivity).HasColumnName("LastClientActivity");

            // Relationships
            this.HasRequired(c => c.User)
                .WithMany(u => u.ConnectedClients)
                .HasForeignKey(c => c.UserKey);

        }
    }
}