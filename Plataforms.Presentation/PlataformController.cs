public class PlataformController //: ControllerBase
{
        private IPlataformService service;
        public PlataformController(IPlataformService service)
        {
            this.service = service;
        }
}