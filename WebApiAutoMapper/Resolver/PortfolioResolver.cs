using AutoMapper;
using System.Text;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper.Resolver
{
    public class PortfolioResolver : IValueResolver<portfolio, DtoPortfolio, DecimalProperties>,
                                        IValueResolver<portfolio, DtoPortfolio, StringProperties>,
                                        IValueResolver<portfolio, DtoPortfolio, DateTimeProperties>,
                                        IValueResolver<portfolio, DtoPortfolio, IntProperties>
    {
        public DecimalProperties Resolve(portfolio source, DtoPortfolio destination, DecimalProperties destMember, ResolutionContext context)
        {
            return new DecimalProperties
            {
                minValue = new decimal[] { source.Prop101, source.Prop102, source.Prop103, source.Prop104, source.Prop105, source.Prop106, source.Prop107, source.Prop108, source.Prop109, source.Prop110 }.Min(),
                maxValue = new decimal[] { source.Prop111, source.Prop112, source.Prop113, source.Prop114, source.Prop115, source.Prop116, source.Prop117, source.Prop118, source.Prop119, source.Prop120 }.Max(),
                avgValue = new decimal[] { source.Prop121, source.Prop122, source.Prop123, source.Prop124, source.Prop125, source.Prop126, source.Prop127, source.Prop128, source.Prop129, source.Prop130, source.Prop131, source.Prop132, source.Prop133, source.Prop134, source.Prop135, source.Prop136, source.Prop137, source.Prop138, source.Prop139, source.Prop140, source.Prop141, source.Prop142, source.Prop143, source.Prop144, source.Prop145, source.Prop146, source.Prop147, source.Prop148, source.Prop149, source.Prop150 }.Average()
            };
        }

        public StringProperties Resolve(portfolio source, DtoPortfolio destination, StringProperties destMember, ResolutionContext context)
        {
            var stringProp = new List<string> { source.Prop1, source.Prop2, source.Prop3, source.Prop4, source.Prop5, source.Prop6, source.Prop7, source.Prop8, source.Prop9, source.Prop10, source.Prop11, source.Prop12, source.Prop13, source.Prop14, source.Prop15, source.Prop16, source.Prop17, source.Prop18, source.Prop19, source.Prop20, source.Prop21, source.Prop22, source.Prop23, source.Prop24, source.Prop25, source.Prop26, source.Prop27, source.Prop28, source.Prop29, source.Prop30, source.Prop31, source.Prop32, source.Prop33, source.Prop34, source.Prop35, source.Prop36, source.Prop37, source.Prop38, source.Prop39, source.Prop40, source.Prop41, source.Prop42, source.Prop43, source.Prop44, source.Prop45, source.Prop46, source.Prop47, source.Prop48, source.Prop49, source.Prop50 };
            var res = new StringBuilder();
            foreach (string item in stringProp)
                res.Append(item);

            return new StringProperties
            {
                value = res.ToString(),
                length = res.Length,
                numWords = res.Length
            };
        }

        public DateTimeProperties Resolve(portfolio source, DtoPortfolio destination, DateTimeProperties destMember, ResolutionContext context)
        {
            var dateProps = new List<DateTime> { source.Prop151, source.Prop152, source.Prop153, source.Prop154, source.Prop155, source.Prop156, source.Prop157, source.Prop158, source.Prop159, source.Prop160, source.Prop161, source.Prop162, source.Prop163, source.Prop164, source.Prop165, source.Prop166, source.Prop167, source.Prop168, source.Prop169, source.Prop170, source.Prop171, source.Prop172, source.Prop173, source.Prop174, source.Prop175, source.Prop176, source.Prop177, source.Prop178, source.Prop179, source.Prop180, source.Prop181, source.Prop182, source.Prop183, source.Prop184, source.Prop185, source.Prop186, source.Prop187, source.Prop188, source.Prop189, source.Prop190, source.Prop191, source.Prop192, source.Prop193, source.Prop194, source.Prop195, source.Prop196, source.Prop197, source.Prop198, source.Prop199, source.Prop190, source.Prop200 };

            return new DateTimeProperties
            {
                minValue = dateProps.Min(),
                maxValue = dateProps.Max()
            };
        }

        public IntProperties Resolve(portfolio source, DtoPortfolio destination, IntProperties destMember, ResolutionContext context)
        {
            var intProps=new int[] { source.Prop51, source.Prop52, source.Prop53, source.Prop54, source.Prop55, source.Prop56, source.Prop57, source.Prop58, source.Prop59, source.Prop60, source.Prop61, source.Prop62, source.Prop63, source.Prop64, source.Prop65, source.Prop66, source.Prop67, source.Prop68, source.Prop69, source.Prop71, source.Prop72, source.Prop73, source.Prop74, source.Prop75, source.Prop76, source.Prop77, source.Prop78, source.Prop79, source.Prop80, source.Prop81, source.Prop82, source.Prop83, source.Prop84, source.Prop85, source.Prop86, source.Prop87, source.Prop88, source.Prop89, source.Prop90, source.Prop91, source.Prop92, source.Prop93, source.Prop94, source.Prop95, source.Prop96, source.Prop97, source.Prop98, source.Prop99, source.Prop100 };
              return new IntProperties
              {
                  minValue = intProps.Min(),
                  maxValue = intProps.Max(),
                  avgValue = intProps.Average()
              };
        }
    }
}
