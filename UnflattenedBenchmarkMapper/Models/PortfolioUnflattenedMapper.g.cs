using BenchmarkMapper.Domains;

namespace BenchmarkMapper.Domains
{
    public static partial class PortfolioUnflattenedMapper
    {
        public static PortfolioUnflattenedMap AdaptToMap(this PortfolioUnflattened p1)
        {
            return p1 == null ? null : new PortfolioUnflattenedMap()
            {
                Id = p1.Id,
                Code = p1.Code,
                Name = p1.Name,
                Type = p1.Type,
                Status = p1.Status,
                GroupStringProperties = p1.GroupStringProperties == null ? null : new StringPropertiesUnflattenedMap()
                {
                    Prop1 = p1.GroupStringProperties.Prop1,
                    Prop2 = p1.GroupStringProperties.Prop2,
                    Prop3 = p1.GroupStringProperties.Prop3,
                    Prop4 = p1.GroupStringProperties.Prop4,
                    Prop5 = p1.GroupStringProperties.Prop5,
                    Prop6 = p1.GroupStringProperties.Prop6,
                    Prop7 = p1.GroupStringProperties.Prop7,
                    Prop8 = p1.GroupStringProperties.Prop8,
                    Prop9 = p1.GroupStringProperties.Prop9,
                    Prop10 = p1.GroupStringProperties.Prop10,
                    Prop11 = p1.GroupStringProperties.Prop11,
                    Prop12 = p1.GroupStringProperties.Prop12,
                    Prop13 = p1.GroupStringProperties.Prop13,
                    Prop14 = p1.GroupStringProperties.Prop14,
                    Prop15 = p1.GroupStringProperties.Prop15,
                    Prop16 = p1.GroupStringProperties.Prop16,
                    Prop17 = p1.GroupStringProperties.Prop17,
                    Prop18 = p1.GroupStringProperties.Prop18,
                    Prop19 = p1.GroupStringProperties.Prop19,
                    Prop20 = p1.GroupStringProperties.Prop20,
                    Prop21 = p1.GroupStringProperties.Prop21,
                    Prop22 = p1.GroupStringProperties.Prop22,
                    Prop23 = p1.GroupStringProperties.Prop23,
                    Prop24 = p1.GroupStringProperties.Prop24,
                    Prop25 = p1.GroupStringProperties.Prop25,
                    Prop26 = p1.GroupStringProperties.Prop26,
                    Prop27 = p1.GroupStringProperties.Prop27,
                    Prop28 = p1.GroupStringProperties.Prop28,
                    Prop29 = p1.GroupStringProperties.Prop29,
                    Prop30 = p1.GroupStringProperties.Prop30,
                    Prop31 = p1.GroupStringProperties.Prop31,
                    Prop32 = p1.GroupStringProperties.Prop32,
                    Prop33 = p1.GroupStringProperties.Prop33,
                    Prop34 = p1.GroupStringProperties.Prop34,
                    Prop35 = p1.GroupStringProperties.Prop35,
                    Prop36 = p1.GroupStringProperties.Prop36,
                    Prop37 = p1.GroupStringProperties.Prop37,
                    Prop38 = p1.GroupStringProperties.Prop38,
                    Prop39 = p1.GroupStringProperties.Prop39,
                    Prop40 = p1.GroupStringProperties.Prop40,
                    Prop41 = p1.GroupStringProperties.Prop41,
                    Prop42 = p1.GroupStringProperties.Prop42,
                    Prop43 = p1.GroupStringProperties.Prop43,
                    Prop44 = p1.GroupStringProperties.Prop44,
                    Prop45 = p1.GroupStringProperties.Prop45,
                    Prop46 = p1.GroupStringProperties.Prop46,
                    Prop47 = p1.GroupStringProperties.Prop47,
                    Prop48 = p1.GroupStringProperties.Prop48,
                    Prop49 = p1.GroupStringProperties.Prop49,
                    Prop50 = p1.GroupStringProperties.Prop50
                },
                GroupIntProperties = p1.GroupIntProperties == null ? null : new IntPropertiesUnflattenedMap()
                {
                    Prop51 = p1.GroupIntProperties.Prop51,
                    Prop52 = p1.GroupIntProperties.Prop52,
                    Prop53 = p1.GroupIntProperties.Prop53,
                    Prop54 = p1.GroupIntProperties.Prop54,
                    Prop55 = p1.GroupIntProperties.Prop55,
                    Prop56 = p1.GroupIntProperties.Prop56,
                    Prop57 = p1.GroupIntProperties.Prop57,
                    Prop58 = p1.GroupIntProperties.Prop58,
                    Prop59 = p1.GroupIntProperties.Prop59,
                    Prop60 = p1.GroupIntProperties.Prop60,
                    Prop61 = p1.GroupIntProperties.Prop61,
                    Prop62 = p1.GroupIntProperties.Prop62,
                    Prop63 = p1.GroupIntProperties.Prop63,
                    Prop64 = p1.GroupIntProperties.Prop64,
                    Prop65 = p1.GroupIntProperties.Prop65,
                    Prop66 = p1.GroupIntProperties.Prop66,
                    Prop67 = p1.GroupIntProperties.Prop67,
                    Prop68 = p1.GroupIntProperties.Prop68,
                    Prop69 = p1.GroupIntProperties.Prop69,
                    Prop70 = p1.GroupIntProperties.Prop70,
                    Prop71 = p1.GroupIntProperties.Prop71,
                    Prop72 = p1.GroupIntProperties.Prop72,
                    Prop73 = p1.GroupIntProperties.Prop73,
                    Prop74 = p1.GroupIntProperties.Prop74,
                    Prop75 = p1.GroupIntProperties.Prop75,
                    Prop76 = p1.GroupIntProperties.Prop76,
                    Prop77 = p1.GroupIntProperties.Prop77,
                    Prop78 = p1.GroupIntProperties.Prop78,
                    Prop79 = p1.GroupIntProperties.Prop79,
                    Prop80 = p1.GroupIntProperties.Prop80,
                    Prop81 = p1.GroupIntProperties.Prop81,
                    Prop82 = p1.GroupIntProperties.Prop82,
                    Prop83 = p1.GroupIntProperties.Prop83,
                    Prop84 = p1.GroupIntProperties.Prop84,
                    Prop85 = p1.GroupIntProperties.Prop85,
                    Prop86 = p1.GroupIntProperties.Prop86,
                    Prop87 = p1.GroupIntProperties.Prop87,
                    Prop88 = p1.GroupIntProperties.Prop88,
                    Prop89 = p1.GroupIntProperties.Prop89,
                    Prop90 = p1.GroupIntProperties.Prop90,
                    Prop91 = p1.GroupIntProperties.Prop91,
                    Prop92 = p1.GroupIntProperties.Prop92,
                    Prop93 = p1.GroupIntProperties.Prop93,
                    Prop94 = p1.GroupIntProperties.Prop94,
                    Prop95 = p1.GroupIntProperties.Prop95,
                    Prop96 = p1.GroupIntProperties.Prop96,
                    Prop97 = p1.GroupIntProperties.Prop97,
                    Prop98 = p1.GroupIntProperties.Prop98,
                    Prop99 = p1.GroupIntProperties.Prop99,
                    Prop100 = p1.GroupIntProperties.Prop100
                },
                GroupDecimalProperties = p1.GroupDecimalProperties == null ? null : new DecimalPropertiesUnflattenedMap()
                {
                    Prop101 = p1.GroupDecimalProperties.Prop101,
                    Prop102 = p1.GroupDecimalProperties.Prop102,
                    Prop103 = p1.GroupDecimalProperties.Prop103,
                    Prop104 = p1.GroupDecimalProperties.Prop104,
                    Prop105 = p1.GroupDecimalProperties.Prop105,
                    Prop106 = p1.GroupDecimalProperties.Prop106,
                    Prop107 = p1.GroupDecimalProperties.Prop107,
                    Prop108 = p1.GroupDecimalProperties.Prop108,
                    Prop109 = p1.GroupDecimalProperties.Prop109,
                    Prop110 = p1.GroupDecimalProperties.Prop110,
                    Prop111 = p1.GroupDecimalProperties.Prop111,
                    Prop112 = p1.GroupDecimalProperties.Prop112,
                    Prop113 = p1.GroupDecimalProperties.Prop113,
                    Prop114 = p1.GroupDecimalProperties.Prop114,
                    Prop115 = p1.GroupDecimalProperties.Prop115,
                    Prop116 = p1.GroupDecimalProperties.Prop116,
                    Prop117 = p1.GroupDecimalProperties.Prop117,
                    Prop118 = p1.GroupDecimalProperties.Prop118,
                    Prop119 = p1.GroupDecimalProperties.Prop119,
                    Prop120 = p1.GroupDecimalProperties.Prop120,
                    Prop121 = p1.GroupDecimalProperties.Prop121,
                    Prop122 = p1.GroupDecimalProperties.Prop122,
                    Prop123 = p1.GroupDecimalProperties.Prop123,
                    Prop124 = p1.GroupDecimalProperties.Prop124,
                    Prop125 = p1.GroupDecimalProperties.Prop125,
                    Prop126 = p1.GroupDecimalProperties.Prop126,
                    Prop127 = p1.GroupDecimalProperties.Prop127,
                    Prop128 = p1.GroupDecimalProperties.Prop128,
                    Prop129 = p1.GroupDecimalProperties.Prop129,
                    Prop130 = p1.GroupDecimalProperties.Prop130,
                    Prop131 = p1.GroupDecimalProperties.Prop131,
                    Prop132 = p1.GroupDecimalProperties.Prop132,
                    Prop133 = p1.GroupDecimalProperties.Prop133,
                    Prop134 = p1.GroupDecimalProperties.Prop134,
                    Prop135 = p1.GroupDecimalProperties.Prop135,
                    Prop136 = p1.GroupDecimalProperties.Prop136,
                    Prop137 = p1.GroupDecimalProperties.Prop137,
                    Prop138 = p1.GroupDecimalProperties.Prop138,
                    Prop139 = p1.GroupDecimalProperties.Prop139,
                    Prop140 = p1.GroupDecimalProperties.Prop140,
                    Prop141 = p1.GroupDecimalProperties.Prop141,
                    Prop142 = p1.GroupDecimalProperties.Prop142,
                    Prop143 = p1.GroupDecimalProperties.Prop143,
                    Prop144 = p1.GroupDecimalProperties.Prop144,
                    Prop145 = p1.GroupDecimalProperties.Prop145,
                    Prop146 = p1.GroupDecimalProperties.Prop146,
                    Prop147 = p1.GroupDecimalProperties.Prop147,
                    Prop148 = p1.GroupDecimalProperties.Prop148,
                    Prop149 = p1.GroupDecimalProperties.Prop149,
                    Prop150 = p1.GroupDecimalProperties.Prop150
                },
                GroupDateTimeProperties = p1.GroupDateTimeProperties == null ? null : new DateTimePropertiesUnflattenedMap()
                {
                    Prop151 = p1.GroupDateTimeProperties.Prop151,
                    Prop152 = p1.GroupDateTimeProperties.Prop152,
                    Prop153 = p1.GroupDateTimeProperties.Prop153,
                    Prop154 = p1.GroupDateTimeProperties.Prop154,
                    Prop155 = p1.GroupDateTimeProperties.Prop155,
                    Prop156 = p1.GroupDateTimeProperties.Prop156,
                    Prop157 = p1.GroupDateTimeProperties.Prop157,
                    Prop158 = p1.GroupDateTimeProperties.Prop158,
                    Prop159 = p1.GroupDateTimeProperties.Prop159,
                    Prop160 = p1.GroupDateTimeProperties.Prop160,
                    Prop161 = p1.GroupDateTimeProperties.Prop161,
                    Prop162 = p1.GroupDateTimeProperties.Prop162,
                    Prop163 = p1.GroupDateTimeProperties.Prop163,
                    Prop164 = p1.GroupDateTimeProperties.Prop164,
                    Prop165 = p1.GroupDateTimeProperties.Prop165,
                    Prop166 = p1.GroupDateTimeProperties.Prop166,
                    Prop167 = p1.GroupDateTimeProperties.Prop167,
                    Prop168 = p1.GroupDateTimeProperties.Prop168,
                    Prop169 = p1.GroupDateTimeProperties.Prop169,
                    Prop170 = p1.GroupDateTimeProperties.Prop170,
                    Prop171 = p1.GroupDateTimeProperties.Prop171,
                    Prop172 = p1.GroupDateTimeProperties.Prop172,
                    Prop173 = p1.GroupDateTimeProperties.Prop173,
                    Prop174 = p1.GroupDateTimeProperties.Prop174,
                    Prop175 = p1.GroupDateTimeProperties.Prop175,
                    Prop176 = p1.GroupDateTimeProperties.Prop176,
                    Prop177 = p1.GroupDateTimeProperties.Prop177,
                    Prop178 = p1.GroupDateTimeProperties.Prop178,
                    Prop179 = p1.GroupDateTimeProperties.Prop179,
                    Prop180 = p1.GroupDateTimeProperties.Prop180,
                    Prop181 = p1.GroupDateTimeProperties.Prop181,
                    Prop182 = p1.GroupDateTimeProperties.Prop182,
                    Prop183 = p1.GroupDateTimeProperties.Prop183,
                    Prop184 = p1.GroupDateTimeProperties.Prop184,
                    Prop185 = p1.GroupDateTimeProperties.Prop185,
                    Prop186 = p1.GroupDateTimeProperties.Prop186,
                    Prop187 = p1.GroupDateTimeProperties.Prop187,
                    Prop188 = p1.GroupDateTimeProperties.Prop188,
                    Prop189 = p1.GroupDateTimeProperties.Prop189,
                    Prop190 = p1.GroupDateTimeProperties.Prop190,
                    Prop191 = p1.GroupDateTimeProperties.Prop191,
                    Prop192 = p1.GroupDateTimeProperties.Prop192,
                    Prop193 = p1.GroupDateTimeProperties.Prop193,
                    Prop194 = p1.GroupDateTimeProperties.Prop194,
                    Prop195 = p1.GroupDateTimeProperties.Prop195,
                    Prop196 = p1.GroupDateTimeProperties.Prop196,
                    Prop197 = p1.GroupDateTimeProperties.Prop197,
                    Prop198 = p1.GroupDateTimeProperties.Prop198,
                    Prop199 = p1.GroupDateTimeProperties.Prop199,
                    Prop200 = p1.GroupDateTimeProperties.Prop200
                }
            };
        }
        public static PortfolioUnflattenedMap AdaptTo(this PortfolioUnflattened p2, PortfolioUnflattenedMap p3)
        {
            if (p2 == null)
            {
                return null;
            }
            PortfolioUnflattenedMap result = p3 ?? new PortfolioUnflattenedMap();
            
            result.Id = p2.Id;
            result.Code = p2.Code;
            result.Name = p2.Name;
            result.Type = p2.Type;
            result.Status = p2.Status;
            result.GroupStringProperties = funcMain1(p2.GroupStringProperties, result.GroupStringProperties);
            result.GroupIntProperties = funcMain2(p2.GroupIntProperties, result.GroupIntProperties);
            result.GroupDecimalProperties = funcMain3(p2.GroupDecimalProperties, result.GroupDecimalProperties);
            result.GroupDateTimeProperties = funcMain4(p2.GroupDateTimeProperties, result.GroupDateTimeProperties);
            return result;
            
        }
        
        private static StringPropertiesUnflattenedMap funcMain1(StringPropertiesUnflattened p4, StringPropertiesUnflattenedMap p5)
        {
            if (p4 == null)
            {
                return null;
            }
            StringPropertiesUnflattenedMap result = p5 ?? new StringPropertiesUnflattenedMap();
            
            result.Prop1 = p4.Prop1;
            result.Prop2 = p4.Prop2;
            result.Prop3 = p4.Prop3;
            result.Prop4 = p4.Prop4;
            result.Prop5 = p4.Prop5;
            result.Prop6 = p4.Prop6;
            result.Prop7 = p4.Prop7;
            result.Prop8 = p4.Prop8;
            result.Prop9 = p4.Prop9;
            result.Prop10 = p4.Prop10;
            result.Prop11 = p4.Prop11;
            result.Prop12 = p4.Prop12;
            result.Prop13 = p4.Prop13;
            result.Prop14 = p4.Prop14;
            result.Prop15 = p4.Prop15;
            result.Prop16 = p4.Prop16;
            result.Prop17 = p4.Prop17;
            result.Prop18 = p4.Prop18;
            result.Prop19 = p4.Prop19;
            result.Prop20 = p4.Prop20;
            result.Prop21 = p4.Prop21;
            result.Prop22 = p4.Prop22;
            result.Prop23 = p4.Prop23;
            result.Prop24 = p4.Prop24;
            result.Prop25 = p4.Prop25;
            result.Prop26 = p4.Prop26;
            result.Prop27 = p4.Prop27;
            result.Prop28 = p4.Prop28;
            result.Prop29 = p4.Prop29;
            result.Prop30 = p4.Prop30;
            result.Prop31 = p4.Prop31;
            result.Prop32 = p4.Prop32;
            result.Prop33 = p4.Prop33;
            result.Prop34 = p4.Prop34;
            result.Prop35 = p4.Prop35;
            result.Prop36 = p4.Prop36;
            result.Prop37 = p4.Prop37;
            result.Prop38 = p4.Prop38;
            result.Prop39 = p4.Prop39;
            result.Prop40 = p4.Prop40;
            result.Prop41 = p4.Prop41;
            result.Prop42 = p4.Prop42;
            result.Prop43 = p4.Prop43;
            result.Prop44 = p4.Prop44;
            result.Prop45 = p4.Prop45;
            result.Prop46 = p4.Prop46;
            result.Prop47 = p4.Prop47;
            result.Prop48 = p4.Prop48;
            result.Prop49 = p4.Prop49;
            result.Prop50 = p4.Prop50;
            return result;
            
        }
        
        private static IntPropertiesUnflattenedMap funcMain2(IntPropertiesUnflattened p6, IntPropertiesUnflattenedMap p7)
        {
            if (p6 == null)
            {
                return null;
            }
            IntPropertiesUnflattenedMap result = p7 ?? new IntPropertiesUnflattenedMap();
            
            result.Prop51 = p6.Prop51;
            result.Prop52 = p6.Prop52;
            result.Prop53 = p6.Prop53;
            result.Prop54 = p6.Prop54;
            result.Prop55 = p6.Prop55;
            result.Prop56 = p6.Prop56;
            result.Prop57 = p6.Prop57;
            result.Prop58 = p6.Prop58;
            result.Prop59 = p6.Prop59;
            result.Prop60 = p6.Prop60;
            result.Prop61 = p6.Prop61;
            result.Prop62 = p6.Prop62;
            result.Prop63 = p6.Prop63;
            result.Prop64 = p6.Prop64;
            result.Prop65 = p6.Prop65;
            result.Prop66 = p6.Prop66;
            result.Prop67 = p6.Prop67;
            result.Prop68 = p6.Prop68;
            result.Prop69 = p6.Prop69;
            result.Prop70 = p6.Prop70;
            result.Prop71 = p6.Prop71;
            result.Prop72 = p6.Prop72;
            result.Prop73 = p6.Prop73;
            result.Prop74 = p6.Prop74;
            result.Prop75 = p6.Prop75;
            result.Prop76 = p6.Prop76;
            result.Prop77 = p6.Prop77;
            result.Prop78 = p6.Prop78;
            result.Prop79 = p6.Prop79;
            result.Prop80 = p6.Prop80;
            result.Prop81 = p6.Prop81;
            result.Prop82 = p6.Prop82;
            result.Prop83 = p6.Prop83;
            result.Prop84 = p6.Prop84;
            result.Prop85 = p6.Prop85;
            result.Prop86 = p6.Prop86;
            result.Prop87 = p6.Prop87;
            result.Prop88 = p6.Prop88;
            result.Prop89 = p6.Prop89;
            result.Prop90 = p6.Prop90;
            result.Prop91 = p6.Prop91;
            result.Prop92 = p6.Prop92;
            result.Prop93 = p6.Prop93;
            result.Prop94 = p6.Prop94;
            result.Prop95 = p6.Prop95;
            result.Prop96 = p6.Prop96;
            result.Prop97 = p6.Prop97;
            result.Prop98 = p6.Prop98;
            result.Prop99 = p6.Prop99;
            result.Prop100 = p6.Prop100;
            return result;
            
        }
        
        private static DecimalPropertiesUnflattenedMap funcMain3(DecimalPropertiesUnflattened p8, DecimalPropertiesUnflattenedMap p9)
        {
            if (p8 == null)
            {
                return null;
            }
            DecimalPropertiesUnflattenedMap result = p9 ?? new DecimalPropertiesUnflattenedMap();
            
            result.Prop101 = p8.Prop101;
            result.Prop102 = p8.Prop102;
            result.Prop103 = p8.Prop103;
            result.Prop104 = p8.Prop104;
            result.Prop105 = p8.Prop105;
            result.Prop106 = p8.Prop106;
            result.Prop107 = p8.Prop107;
            result.Prop108 = p8.Prop108;
            result.Prop109 = p8.Prop109;
            result.Prop110 = p8.Prop110;
            result.Prop111 = p8.Prop111;
            result.Prop112 = p8.Prop112;
            result.Prop113 = p8.Prop113;
            result.Prop114 = p8.Prop114;
            result.Prop115 = p8.Prop115;
            result.Prop116 = p8.Prop116;
            result.Prop117 = p8.Prop117;
            result.Prop118 = p8.Prop118;
            result.Prop119 = p8.Prop119;
            result.Prop120 = p8.Prop120;
            result.Prop121 = p8.Prop121;
            result.Prop122 = p8.Prop122;
            result.Prop123 = p8.Prop123;
            result.Prop124 = p8.Prop124;
            result.Prop125 = p8.Prop125;
            result.Prop126 = p8.Prop126;
            result.Prop127 = p8.Prop127;
            result.Prop128 = p8.Prop128;
            result.Prop129 = p8.Prop129;
            result.Prop130 = p8.Prop130;
            result.Prop131 = p8.Prop131;
            result.Prop132 = p8.Prop132;
            result.Prop133 = p8.Prop133;
            result.Prop134 = p8.Prop134;
            result.Prop135 = p8.Prop135;
            result.Prop136 = p8.Prop136;
            result.Prop137 = p8.Prop137;
            result.Prop138 = p8.Prop138;
            result.Prop139 = p8.Prop139;
            result.Prop140 = p8.Prop140;
            result.Prop141 = p8.Prop141;
            result.Prop142 = p8.Prop142;
            result.Prop143 = p8.Prop143;
            result.Prop144 = p8.Prop144;
            result.Prop145 = p8.Prop145;
            result.Prop146 = p8.Prop146;
            result.Prop147 = p8.Prop147;
            result.Prop148 = p8.Prop148;
            result.Prop149 = p8.Prop149;
            result.Prop150 = p8.Prop150;
            return result;
            
        }
        
        private static DateTimePropertiesUnflattenedMap funcMain4(DateTimePropertiesUnflattened p10, DateTimePropertiesUnflattenedMap p11)
        {
            if (p10 == null)
            {
                return null;
            }
            DateTimePropertiesUnflattenedMap result = p11 ?? new DateTimePropertiesUnflattenedMap();
            
            result.Prop151 = p10.Prop151;
            result.Prop152 = p10.Prop152;
            result.Prop153 = p10.Prop153;
            result.Prop154 = p10.Prop154;
            result.Prop155 = p10.Prop155;
            result.Prop156 = p10.Prop156;
            result.Prop157 = p10.Prop157;
            result.Prop158 = p10.Prop158;
            result.Prop159 = p10.Prop159;
            result.Prop160 = p10.Prop160;
            result.Prop161 = p10.Prop161;
            result.Prop162 = p10.Prop162;
            result.Prop163 = p10.Prop163;
            result.Prop164 = p10.Prop164;
            result.Prop165 = p10.Prop165;
            result.Prop166 = p10.Prop166;
            result.Prop167 = p10.Prop167;
            result.Prop168 = p10.Prop168;
            result.Prop169 = p10.Prop169;
            result.Prop170 = p10.Prop170;
            result.Prop171 = p10.Prop171;
            result.Prop172 = p10.Prop172;
            result.Prop173 = p10.Prop173;
            result.Prop174 = p10.Prop174;
            result.Prop175 = p10.Prop175;
            result.Prop176 = p10.Prop176;
            result.Prop177 = p10.Prop177;
            result.Prop178 = p10.Prop178;
            result.Prop179 = p10.Prop179;
            result.Prop180 = p10.Prop180;
            result.Prop181 = p10.Prop181;
            result.Prop182 = p10.Prop182;
            result.Prop183 = p10.Prop183;
            result.Prop184 = p10.Prop184;
            result.Prop185 = p10.Prop185;
            result.Prop186 = p10.Prop186;
            result.Prop187 = p10.Prop187;
            result.Prop188 = p10.Prop188;
            result.Prop189 = p10.Prop189;
            result.Prop190 = p10.Prop190;
            result.Prop191 = p10.Prop191;
            result.Prop192 = p10.Prop192;
            result.Prop193 = p10.Prop193;
            result.Prop194 = p10.Prop194;
            result.Prop195 = p10.Prop195;
            result.Prop196 = p10.Prop196;
            result.Prop197 = p10.Prop197;
            result.Prop198 = p10.Prop198;
            result.Prop199 = p10.Prop199;
            result.Prop200 = p10.Prop200;
            return result;
            
        }
    }
}