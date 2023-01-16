﻿using FlattenedBenchmarkMapper.Domains;
using FlattenedBenchmarkMapper.Dto;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenedBenchmarkMapper
{
    internal class MapsterConfig: ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Map").ForType<PortfolioSmall>(
                cfg =>
                {
                    cfg.Map(dest => dest.Id, "DtoId");
                    cfg.Map(dest => dest.Code, "DtoCode");
                    cfg.Map(dest => dest.Name, "DtoName");
                    cfg.Map(dest => dest.Type, "DtoType");
                    cfg.Map(dest => dest.Status, "DtoStatus");
                }
             );

            config.AdaptTo("[name]Map").ForType<PortfolioBig>(
                cfg =>
                {
                    cfg.Map(dest => dest.Id, "DtoId");
                    cfg.Map(dest => dest.Code, "DtoCode");
                    cfg.Map(dest => dest.Name, "DtoName");
                    cfg.Map(dest => dest.Type, "DtoType");
                    cfg.Map(dest => dest.Status, "DtoDtoStatus");
                    cfg.Map(dest => dest.Prop1, "DtoProp1");
                    cfg.Map(dest => dest.Prop2, "DtoProp2");
                    cfg.Map(dest => dest.Prop3, "DtoProp3");
                    cfg.Map(dest => dest.Prop4, "DtoProp4");
                    cfg.Map(dest => dest.Prop5, "DtoProp5");
                    cfg.Map(dest => dest.Prop6, "DtoProp6");
                    cfg.Map(dest => dest.Prop7, "DtoProp7");
                    cfg.Map(dest => dest.Prop8, "DtoProp8");
                    cfg.Map(dest => dest.Prop9, "DtoProp9");
                    cfg.Map(dest => dest.Prop10, "DtoProp10");
                    cfg.Map(dest => dest.Prop11, "DtoProp11");
                    cfg.Map(dest => dest.Prop12, "DtoProp12");
                    cfg.Map(dest => dest.Prop13, "DtoProp13");
                    cfg.Map(dest => dest.Prop14, "DtoProp14");
                    cfg.Map(dest => dest.Prop15, "DtoProp15");
                    cfg.Map(dest => dest.Prop16, "DtoProp16");
                    cfg.Map(dest => dest.Prop17, "DtoProp17");
                    cfg.Map(dest => dest.Prop18, "DtoProp18");
                    cfg.Map(dest => dest.Prop19, "DtoProp19");
                    cfg.Map(dest => dest.Prop20, "DtoProp20");
                    cfg.Map(dest => dest.Prop21, "DtoProp21");
                    cfg.Map(dest => dest.Prop22, "DtoProp22");
                    cfg.Map(dest => dest.Prop23, "DtoProp23");
                    cfg.Map(dest => dest.Prop24, "DtoProp24");
                    cfg.Map(dest => dest.Prop25, "DtoProp25");
                    cfg.Map(dest => dest.Prop26, "DtoProp26");
                    cfg.Map(dest => dest.Prop27, "DtoProp27");
                    cfg.Map(dest => dest.Prop28, "DtoProp28");
                    cfg.Map(dest => dest.Prop29, "DtoProp29");
                    cfg.Map(dest => dest.Prop30, "DtoProp30");
                    cfg.Map(dest => dest.Prop31, "DtoProp31");
                    cfg.Map(dest => dest.Prop32, "DtoProp32");
                    cfg.Map(dest => dest.Prop33, "DtoProp33");
                    cfg.Map(dest => dest.Prop34, "DtoProp34");
                    cfg.Map(dest => dest.Prop35, "DtoProp35");
                    cfg.Map(dest => dest.Prop36, "DtoProp36");
                    cfg.Map(dest => dest.Prop37, "DtoProp37");
                    cfg.Map(dest => dest.Prop38, "DtoProp38");
                    cfg.Map(dest => dest.Prop39, "DtoProp39");
                    cfg.Map(dest => dest.Prop40, "DtoProp40");
                    cfg.Map(dest => dest.Prop41, "DtoProp41");
                    cfg.Map(dest => dest.Prop42, "DtoProp42");
                    cfg.Map(dest => dest.Prop43, "DtoProp43");
                    cfg.Map(dest => dest.Prop44, "DtoProp44");
                    cfg.Map(dest => dest.Prop45, "DtoProp45");
                    cfg.Map(dest => dest.Prop46, "DtoProp46");
                    cfg.Map(dest => dest.Prop47, "DtoProp47");
                    cfg.Map(dest => dest.Prop48, "DtoProp48");
                    cfg.Map(dest => dest.Prop49, "DtoProp49");
                    cfg.Map(dest => dest.Prop50, "DtoProp50");
                    cfg.Map(dest => dest.Prop51, "DtoProp51");
                    cfg.Map(dest => dest.Prop52, "DtoProp52");
                    cfg.Map(dest => dest.Prop53, "DtoProp53");
                    cfg.Map(dest => dest.Prop54, "DtoProp54");
                    cfg.Map(dest => dest.Prop55, "DtoProp55");
                    cfg.Map(dest => dest.Prop56, "DtoProp56");
                    cfg.Map(dest => dest.Prop57, "DtoProp57");
                    cfg.Map(dest => dest.Prop58, "DtoProp58");
                    cfg.Map(dest => dest.Prop59, "DtoProp59");
                    cfg.Map(dest => dest.Prop60, "DtoProp60");
                    cfg.Map(dest => dest.Prop61, "DtoProp61");
                    cfg.Map(dest => dest.Prop62, "DtoProp62");
                    cfg.Map(dest => dest.Prop63, "DtoProp63");
                    cfg.Map(dest => dest.Prop64, "DtoProp64");
                    cfg.Map(dest => dest.Prop65, "DtoProp65");
                    cfg.Map(dest => dest.Prop66, "DtoProp66");
                    cfg.Map(dest => dest.Prop67, "DtoProp67");
                    cfg.Map(dest => dest.Prop68, "DtoProp68");
                    cfg.Map(dest => dest.Prop69, "DtoProp69");
                    cfg.Map(dest => dest.Prop70, "DtoProp70");
                    cfg.Map(dest => dest.Prop71, "DtoProp71");
                    cfg.Map(dest => dest.Prop72, "DtoProp72");
                    cfg.Map(dest => dest.Prop73, "DtoProp73");
                    cfg.Map(dest => dest.Prop74, "DtoProp74");
                    cfg.Map(dest => dest.Prop75, "DtoProp75");
                    cfg.Map(dest => dest.Prop76, "DtoProp76");
                    cfg.Map(dest => dest.Prop77, "DtoProp77");
                    cfg.Map(dest => dest.Prop78, "DtoProp78");
                    cfg.Map(dest => dest.Prop79, "DtoProp79");
                    cfg.Map(dest => dest.Prop80, "DtoProp80");
                    cfg.Map(dest => dest.Prop81, "DtoProp81");
                    cfg.Map(dest => dest.Prop82, "DtoProp82");
                    cfg.Map(dest => dest.Prop83, "DtoProp83");
                    cfg.Map(dest => dest.Prop84, "DtoProp84");
                    cfg.Map(dest => dest.Prop85, "DtoProp85");
                    cfg.Map(dest => dest.Prop86, "DtoProp86");
                    cfg.Map(dest => dest.Prop87, "DtoProp87");
                    cfg.Map(dest => dest.Prop88, "DtoProp88");
                    cfg.Map(dest => dest.Prop89, "DtoProp89");
                    cfg.Map(dest => dest.Prop90, "DtoProp90");
                    cfg.Map(dest => dest.Prop91, "DtoProp91");
                    cfg.Map(dest => dest.Prop92, "DtoProp92");
                    cfg.Map(dest => dest.Prop93, "DtoProp93");
                    cfg.Map(dest => dest.Prop94, "DtoProp94");
                    cfg.Map(dest => dest.Prop95, "DtoProp95");
                    cfg.Map(dest => dest.Prop96, "DtoProp96");
                    cfg.Map(dest => dest.Prop97, "DtoProp97");
                    cfg.Map(dest => dest.Prop98, "DtoProp98");
                    cfg.Map(dest => dest.Prop99, "DtoProp99");
                    cfg.Map(dest => dest.Prop100, "DtoProp100");
                    cfg.Map(dest => dest.Prop101, "DtoProp101");
                    cfg.Map(dest => dest.Prop102, "DtoProp102");
                    cfg.Map(dest => dest.Prop103, "DtoProp103");
                    cfg.Map(dest => dest.Prop104, "DtoProp104");
                    cfg.Map(dest => dest.Prop105, "DtoProp105");
                    cfg.Map(dest => dest.Prop106, "DtoProp106");
                    cfg.Map(dest => dest.Prop107, "DtoProp107");
                    cfg.Map(dest => dest.Prop108, "DtoProp108");
                    cfg.Map(dest => dest.Prop109, "DtoProp109");
                    cfg.Map(dest => dest.Prop110, "DtoProp110");
                    cfg.Map(dest => dest.Prop111, "DtoProp111");
                    cfg.Map(dest => dest.Prop112, "DtoProp112");
                    cfg.Map(dest => dest.Prop113, "DtoProp113");
                    cfg.Map(dest => dest.Prop114, "DtoProp114");
                    cfg.Map(dest => dest.Prop115, "DtoProp115");
                    cfg.Map(dest => dest.Prop116, "DtoProp116");
                    cfg.Map(dest => dest.Prop117, "DtoProp117");
                    cfg.Map(dest => dest.Prop118, "DtoProp118");
                    cfg.Map(dest => dest.Prop119, "DtoProp119");
                    cfg.Map(dest => dest.Prop120, "DtoProp120");
                    cfg.Map(dest => dest.Prop121, "DtoProp121");
                    cfg.Map(dest => dest.Prop122, "DtoProp122");
                    cfg.Map(dest => dest.Prop123, "DtoProp123");
                    cfg.Map(dest => dest.Prop124, "DtoProp124");
                    cfg.Map(dest => dest.Prop125, "DtoProp125");
                    cfg.Map(dest => dest.Prop126, "DtoProp126");
                    cfg.Map(dest => dest.Prop127, "DtoProp127");
                    cfg.Map(dest => dest.Prop128, "DtoProp128");
                    cfg.Map(dest => dest.Prop129, "DtoProp129");
                    cfg.Map(dest => dest.Prop130, "DtoProp130");
                    cfg.Map(dest => dest.Prop131, "DtoProp131");
                    cfg.Map(dest => dest.Prop132, "DtoProp132");
                    cfg.Map(dest => dest.Prop133, "DtoProp133");
                    cfg.Map(dest => dest.Prop134, "DtoProp134");
                    cfg.Map(dest => dest.Prop135, "DtoProp135");
                    cfg.Map(dest => dest.Prop136, "DtoProp136");
                    cfg.Map(dest => dest.Prop137, "DtoProp137");
                    cfg.Map(dest => dest.Prop138, "DtoProp138");
                    cfg.Map(dest => dest.Prop139, "DtoProp139");
                    cfg.Map(dest => dest.Prop140, "DtoProp140");
                    cfg.Map(dest => dest.Prop141, "DtoProp141");
                    cfg.Map(dest => dest.Prop142, "DtoProp142");
                    cfg.Map(dest => dest.Prop143, "DtoProp143");
                    cfg.Map(dest => dest.Prop144, "DtoProp144");
                    cfg.Map(dest => dest.Prop145, "DtoProp145");
                    cfg.Map(dest => dest.Prop146, "DtoProp146");
                    cfg.Map(dest => dest.Prop147, "DtoProp147");
                    cfg.Map(dest => dest.Prop148, "DtoProp148");
                    cfg.Map(dest => dest.Prop149, "DtoProp149");
                    cfg.Map(dest => dest.Prop150, "DtoProp150");
                    cfg.Map(dest => dest.Prop151, "DtoProp151");
                    cfg.Map(dest => dest.Prop152, "DtoProp152");
                    cfg.Map(dest => dest.Prop153, "DtoProp153");
                    cfg.Map(dest => dest.Prop154, "DtoProp154");
                    cfg.Map(dest => dest.Prop155, "DtoProp155");
                    cfg.Map(dest => dest.Prop156, "DtoProp156");
                    cfg.Map(dest => dest.Prop157, "DtoProp157");
                    cfg.Map(dest => dest.Prop158, "DtoProp158");
                    cfg.Map(dest => dest.Prop159, "DtoProp159");
                    cfg.Map(dest => dest.Prop160, "DtoProp160");
                    cfg.Map(dest => dest.Prop161, "DtoProp161");
                    cfg.Map(dest => dest.Prop162, "DtoProp162");
                    cfg.Map(dest => dest.Prop163, "DtoProp163");
                    cfg.Map(dest => dest.Prop164, "DtoProp164");
                    cfg.Map(dest => dest.Prop165, "DtoProp165");
                    cfg.Map(dest => dest.Prop166, "DtoProp166");
                    cfg.Map(dest => dest.Prop167, "DtoProp167");
                    cfg.Map(dest => dest.Prop168, "DtoProp168");
                    cfg.Map(dest => dest.Prop169, "DtoProp169");
                    cfg.Map(dest => dest.Prop170, "DtoProp170");
                    cfg.Map(dest => dest.Prop171, "DtoProp171");
                    cfg.Map(dest => dest.Prop172, "DtoProp172");
                    cfg.Map(dest => dest.Prop173, "DtoProp173");
                    cfg.Map(dest => dest.Prop174, "DtoProp174");
                    cfg.Map(dest => dest.Prop175, "DtoProp175");
                    cfg.Map(dest => dest.Prop176, "DtoProp176");
                    cfg.Map(dest => dest.Prop177, "DtoProp177");
                    cfg.Map(dest => dest.Prop178, "DtoProp178");
                    cfg.Map(dest => dest.Prop179, "DtoProp179");
                    cfg.Map(dest => dest.Prop180, "DtoProp180");
                    cfg.Map(dest => dest.Prop181, "DtoProp181");
                    cfg.Map(dest => dest.Prop182, "DtoProp182");
                    cfg.Map(dest => dest.Prop183, "DtoProp183");
                    cfg.Map(dest => dest.Prop184, "DtoProp184");
                    cfg.Map(dest => dest.Prop185, "DtoProp185");
                    cfg.Map(dest => dest.Prop186, "DtoProp186");
                    cfg.Map(dest => dest.Prop187, "DtoProp187");
                    cfg.Map(dest => dest.Prop188, "DtoProp188");
                    cfg.Map(dest => dest.Prop189, "DtoProp189");
                    cfg.Map(dest => dest.Prop190, "DtoProp190");
                    cfg.Map(dest => dest.Prop191, "DtoProp191");
                    cfg.Map(dest => dest.Prop192, "DtoProp192");
                    cfg.Map(dest => dest.Prop193, "DtoProp193");
                    cfg.Map(dest => dest.Prop194, "DtoProp194");
                    cfg.Map(dest => dest.Prop195, "DtoProp195");
                    cfg.Map(dest => dest.Prop196, "DtoProp196");
                    cfg.Map(dest => dest.Prop197, "DtoProp197");
                    cfg.Map(dest => dest.Prop198, "DtoProp198");
                    cfg.Map(dest => dest.Prop199, "DtoProp199");
                    cfg.Map(dest => dest.Prop200, "DtoProp200"); 
                }
             );
        }
    }
}
