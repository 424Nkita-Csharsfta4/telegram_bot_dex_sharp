using Domain.Entyti.ValueObject;

namespace Domain.Entyti;

/// <summary>
/// 
/// </summary>
public class Person : BaseEntity
{
   
   // згидшс Зукыщт(FullName fullName)Х
      
   public FullName FullName { get; set; }

   public DateTime BirthDay { get; set;}

   public  int Age => DateTime.Now.Year - BirthDay.Year;

   public string PhoneNumber { get; set; }
   public string Telegram { get; set; }

   private FullName ValidateFullName(FullName fullName)
   {
      if (string.IsNullOrEmpty((fullName.FirstName)string.IsNullOrEmpty((fullName.LastName))))
      {
         throw new AggregateException();
      }

      if (fullName.MiddleName is not null)
      {
         if (fullName.MiddleName == string.Empty)
         {
            throw new AggregateException("");
         }
      }
      //TODO: Дпустимы только буквы русскоого и англ алфавита
      return fullName;
      //возраст до 150
      //ник в ТГ через @
      //для номера наш ПМР
   }
}