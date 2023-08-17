using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Constants
{
	public static class Messages
	{
		#region User

		public static string UserAdded = "Kullanıcı Eklendi";
		public static string UserNotAdded = "Hata! Kullanıcı Eklenemedi";
		public static string UserUpdated = "Kullanıcı Güncellendi";
		public static string UserNotUpdated = "Hata! Kullanıcı Güncellenemedi";
		public static string UserNotDeleted = "Hata! Kullanıcı Silinemedi";
		public static string UserDeleted = "Kullanıcı Silindi";
		public static string UserGetAll = "Kullanıcılar Getirildi";
		public static string UserNotGetAll = "Hata! Kullanıcılar Getirilirken bir hatayla karşılaşıldı"; 

		#endregion

		#region RetailCustomer

		public static string RetailCustomerAdded = "Bireysel Müşteri Eklendi";
		public static string RetailCustomerNotAdded = "Hata! Bireysel Müşteri Eklenemedi";
		public static string RetailCustomerUpdated = "Bireysel Müşteri Güncellendi";
		public static string RetailCustomerNotUpdated = "Hata! Bireysel Müşteri Güncellenemedi";
		public static string RetailCustomerNotDeleted = "Hata! Bireysel Müşteri Silinemedi";
		public static string RetailCustomerDeleted = "Bireysel Müşteri Silindi";
		public static string RetailCustomerGetAll = "Bireysel Müşteriler Getirildi";
		public static string RetailCustomerNotGetAll = "Hata! Bireysel Müşteriler Getirilirken bir hatayla karşılaşıldı";

		#endregion

		#region Employee

		public static string EmployeeAdded = "Şirket Çalışanı Eklendi";
		public static string EmployeeNotAdded = "Hata! Şirket Çalışanı Eklenemedi";

		#endregion

		#region AccountMessages

		public static string AccountInformationIsCorrect = "Giriş Bilgileri Doğru";
		public static string UserNotFound = "Kullanıcı Bulunamadı"; 

		#endregion

		public static string RetailCustomerExists = "Bireysel Müşteri Mevcut";
	}
}
