using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using DAL.DbCont;
using DAL.Model;
using System.Linq;



//TCP, HTTP, MSMQ, Web Servisleri
//Address zmetim intranet/internet üzerinde hangi adreste bulunmakta?

//Binding (Bağlayıcı) Hizmetimle ne şekilde konuşulacak? 
//Binding servisin erişebilirliği ile ilgilenir. Servise dış dünyanın hangi kurallar ile bağlanabileceğini belirler.


//Contract  Hizmetim kullanıcılara hangi fonksiyonaliteleri sunacak
//Contract, client ın servis ile yapabileceği işlemleri ifade eder.
//Service Contract: Servis ile yarattığımız operasyonları tanımlaya yarar.
//Data Contract : Verileri tanımlamamıza yarar.
//Fault Contract: Servis tarafından hata tanımlamaya yarar.
//Message Contract: Servisler ile mesajlar arasında iletişim kurmaya yarar.

//WCF temelinde servis üç adımda geliştirilir.

//1. Servis yaratılır.(Creating)
//2. Servise bir adres bağlanır ve host edilir. (Hosting) 
//3. Client tarafından eklenerek kullanılır.(Consuming)

//Endpointler servisin iletişimini sağlayan ve iletişim kurallarını belirleyen yapılardır. Client tarafında bir tane, sunucu tarafında ise n tane olabilir. 


// Bu protokollerden servis verebilir.
//HTTP(http:// yada https:// )
//TCP (net.tcp :// )
//Peer 2 Peer (net.p2p://)
//IPC (Inter-Process Communication over named pipes)(net.pipe://)
//MSMQ(net.msmq://)

namespace LokantaWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface LokantaService
    {
        [OperationContract]
         List<Duyurular> WFDuyurular();
        
   
    }



    [DataContract]
    public class CompositeType:LokantaService
    {
              
        public List<Duyurular> WFDuyurular()
        {   //DAL dan veri tabanına erişmek için reference den DAL ı LokantaWCFServiceye ekledim //Asemby dilinde dllleri eşletirme.
            // using ile tanımlanan DAL.Model in Duyurular classının Context teki nesnesi oluşturuldu.
            LokantaContext model = new LokantaContext();
            //listi diziden ayıran en önemli özellik list sınırsız dizi sınırları belirleriz.
            //Dal Context sınıfından tanımlanan nesne isle linq kullanılarak veri tabanından veriler çekildi.  
            List<Duyurular> duyuru = model.Duyurular.OrderByDescending(x => x.DuyuruID).Take(3).ToList();
            return duyuru;    
        }
    }
}
