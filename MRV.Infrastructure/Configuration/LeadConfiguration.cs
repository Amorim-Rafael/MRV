using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRV.Domain.Entities;

namespace MRV.Infrastructure.Configuration
{
    public class LeadConfiguration : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.FirstName).IsRequired();
            builder.Property(l => l.FullName).IsRequired();
            builder.Property(l => l.PhoneNumber).IsRequired();
            builder.Property(l => l.Email).IsRequired();
            builder.Property(l => l.Suburb).IsRequired();
            builder.Property(l => l.Category).IsRequired();
            builder.Property(l => l.Description).IsRequired();
            builder.Property(l => l.Price).IsRequired();
            builder.Property(l => l.Accepted).IsRequired();
            builder.Property(l => l.DateCreated).IsRequired();

            builder.HasData(
                new Lead(1, "Mestre", "Mestre do Magos", "99 999999999", "mestre@magos.com", "A Noite sem Amanhã", "Fantasia", "Caverna do Dragão", 100, false),
                new Lead(2, "Hank", "Hank Arqueiro", "11 111111111", "hank@ded.com", "O Olho do Observador", "Fantasia", "Caverna do Dragão", 750, false),
                new Lead(3, "Eric", "Eric Cavaleiro", "22 222222222", "eric@ded.com", "O Salão dos Ossos", "Fantasia", "Caverna do Dragão", 800, false),
                new Lead(4, "Diana", "Diana Acrobata", "33 333333333", "diana@ded.com", "O Vale dos Unicórnios", "Fantasia", "Caverna do Dragão", 320, false),
                new Lead(5, "Sheila", "Sheila Ladina", "44 444444444", "sheila@ded.com", "Em Busca do Mestre dos Magos", "Fantasia", "Caverna do Dragão", 500, false),
                new Lead(6, "Bobby", "Bobby Barbaro", "55 555555555", "bobby@ded.com", "A Bela e a Fera do Pântano", "Fantasia", "Caverna do Dragão", 450, false),
                new Lead(7, "Uni", "Uni Unicornio", "66 666666666", "uni@ded.com", "Prisão sem Muros", "Fantasia", "Caverna do Dragão", 501, false),
                new Lead(8, "Presto", "Presto Mago", "77 777777777", "presto@ded.com", "Servo do Mal", "Fantasia", "Caverna do Dragão", 625, false)
            );
        }
    }
}
