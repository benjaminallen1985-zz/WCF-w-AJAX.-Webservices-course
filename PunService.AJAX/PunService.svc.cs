using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Data;

namespace PunService.AJAX
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PunService
    {
        private PunDataService _service;
        
        public PunService()
        {
            _service = new PunDataService();
        }
        
        [WebGet(ResponseFormat = WebMessageFormat.Xml)]
        public Pun[] GetPuns()
        {
            return _service.GetPuns();
        }

        [OperationContract]
        [WebGet]
        public Pun GetPunByID(int punID)
        {
            return _service.GetPunById(punID);
        }

        [OperationContract]
        [WebInvoke]
        public void CreatePun(Pun pun)
        {
            _service.AddPun(pun);
        }

        [OperationContract]
        [WebInvoke]
        public void UpdatePun(Pun pun)
        {
            _service.UpdatePun(pun);
        }

        [OperationContract]
        [WebInvoke]
        public void DeletePun(int id)
        {
            _service.DeletePun(id);
        }
    }
}
