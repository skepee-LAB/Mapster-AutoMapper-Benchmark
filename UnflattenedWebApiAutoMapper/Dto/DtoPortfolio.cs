﻿using System.ComponentModel.DataAnnotations;

namespace WebApiAutoMapper.Dto
{
    public class DtoPortfolioFull
    { 
        public DtoPortfolio portfolio { get; set; }
        public DtoIntProperties intProperties { get; set; }
        public DtoDateTimeProperties dateTimeProperties { get; set; }
        public DtoStringProperties stringProperties { get; set; }
        public DtoDecimalProperties decimalProperties { get; set; }
    }


    public class DtoPortfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioCode { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioType { get; set; }
        public string PortfolioStatus { get; set; }
        public DtoStringProperties GroupStringProperties { get; set; }
        public DtoIntProperties GroupIntProperties { get; set; }
        public DtoDecimalProperties GroupDecimalProperties { get; set; }
        public DtoDateTimeProperties GroupDateTimeProperties { get; set; }
    }

    public class DtoDecimalProperties
    {
        public int Id { get; set; }
        public decimal Prop101 { get; set; }
        public decimal Prop102 { get; set; }
        public decimal Prop103 { get; set; }
        public decimal Prop104 { get; set; }
        public decimal Prop105 { get; set; }
        public decimal Prop106 { get; set; }
        public decimal Prop107 { get; set; }
        public decimal Prop108 { get; set; }
        public decimal Prop109 { get; set; }
        public decimal Prop110 { get; set; }
        public decimal Prop111 { get; set; }
        public decimal Prop112 { get; set; }
        public decimal Prop113 { get; set; }
        public decimal Prop114 { get; set; }
        public decimal Prop115 { get; set; }
        public decimal Prop116 { get; set; }
        public decimal Prop117 { get; set; }
        public decimal Prop118 { get; set; }
        public decimal Prop119 { get; set; }
        public decimal Prop120 { get; set; }
        public decimal Prop121 { get; set; }
        public decimal Prop122 { get; set; }
        public decimal Prop123 { get; set; }
        public decimal Prop124 { get; set; }
        public decimal Prop125 { get; set; }
        public decimal Prop126 { get; set; }
        public decimal Prop127 { get; set; }
        public decimal Prop128 { get; set; }
        public decimal Prop129 { get; set; }
        public decimal Prop130 { get; set; }
        public decimal Prop131 { get; set; }
        public decimal Prop132 { get; set; }
        public decimal Prop133 { get; set; }
        public decimal Prop134 { get; set; }
        public decimal Prop135 { get; set; }
        public decimal Prop136 { get; set; }
        public decimal Prop137 { get; set; }
        public decimal Prop138 { get; set; }
        public decimal Prop139 { get; set; }
        public decimal Prop140 { get; set; }
        public decimal Prop141 { get; set; }
        public decimal Prop142 { get; set; }
        public decimal Prop143 { get; set; }
        public decimal Prop144 { get; set; }
        public decimal Prop145 { get; set; }
        public decimal Prop146 { get; set; }
        public decimal Prop147 { get; set; }
        public decimal Prop148 { get; set; }
        public decimal Prop149 { get; set; }
        public decimal Prop150 { get; set; }

    }

    public class DtoIntProperties
    {
        public int Id { get; set; }
        public int Prop51 { get; set; }
        public int Prop52 { get; set; }
        public int Prop53 { get; set; }
        public int Prop54 { get; set; }
        public int Prop55 { get; set; }
        public int Prop56 { get; set; }
        public int Prop57 { get; set; }
        public int Prop58 { get; set; }
        public int Prop59 { get; set; }
        public int Prop60 { get; set; }
        public int Prop61 { get; set; }
        public int Prop62 { get; set; }
        public int Prop63 { get; set; }
        public int Prop64 { get; set; }
        public int Prop65 { get; set; }
        public int Prop66 { get; set; }
        public int Prop67 { get; set; }
        public int Prop68 { get; set; }
        public int Prop69 { get; set; }
        public int Prop71 { get; set; }
        public int Prop72 { get; set; }
        public int Prop73 { get; set; }
        public int Prop74 { get; set; }
        public int Prop75 { get; set; }
        public int Prop76 { get; set; }
        public int Prop77 { get; set; }
        public int Prop78 { get; set; }
        public int Prop79 { get; set; }
        public int Prop80 { get; set; }
        public int Prop81 { get; set; }
        public int Prop82 { get; set; }
        public int Prop83 { get; set; }
        public int Prop84 { get; set; }
        public int Prop85 { get; set; }
        public int Prop86 { get; set; }
        public int Prop87 { get; set; }
        public int Prop88 { get; set; }
        public int Prop89 { get; set; }
        public int Prop90 { get; set; }
        public int Prop91 { get; set; }
        public int Prop92 { get; set; }
        public int Prop93 { get; set; }
        public int Prop94 { get; set; }
        public int Prop95 { get; set; }
        public int Prop96 { get; set; }
        public int Prop97 { get; set; }
        public int Prop98 { get; set; }
        public int Prop99 { get; set; }
        public int Prop100 { get; set; }
    }

    public class DtoStringProperties
    {
        public int Id { get; set; }
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }
        public string Prop3 { get; set; }
        public string Prop4 { get; set; }
        public string Prop5 { get; set; }
        public string Prop6 { get; set; }
        public string Prop7 { get; set; }
        public string Prop8 { get; set; }
        public string Prop9 { get; set; }
        public string Prop10 { get; set; }
        public string Prop11 { get; set; }
        public string Prop12 { get; set; }
        public string Prop13 { get; set; }
        public string Prop14 { get; set; }
        public string Prop15 { get; set; }
        public string Prop16 { get; set; }
        public string Prop17 { get; set; }
        public string Prop18 { get; set; }
        public string Prop19 { get; set; }
        public string Prop20 { get; set; }
        public string Prop21 { get; set; }
        public string Prop22 { get; set; }
        public string Prop23 { get; set; }
        public string Prop24 { get; set; }
        public string Prop25 { get; set; }
        public string Prop26 { get; set; }
        public string Prop27 { get; set; }
        public string Prop28 { get; set; }
        public string Prop29 { get; set; }
        public string Prop30 { get; set; }
        public string Prop31 { get; set; }
        public string Prop32 { get; set; }
        public string Prop33 { get; set; }
        public string Prop34 { get; set; }
        public string Prop35 { get; set; }
        public string Prop36 { get; set; }
        public string Prop37 { get; set; }
        public string Prop38 { get; set; }
        public string Prop39 { get; set; }
        public string Prop40 { get; set; }
        public string Prop41 { get; set; }
        public string Prop42 { get; set; }
        public string Prop43 { get; set; }
        public string Prop44 { get; set; }
        public string Prop45 { get; set; }
        public string Prop46 { get; set; }
        public string Prop47 { get; set; }
        public string Prop48 { get; set; }
        public string Prop49 { get; set; }
        public string Prop50 { get; set; }
    }

    public class DtoDateTimeProperties
    {
        public int Id { get; set; }
        public DateTime Prop151 { get; set; }
        public DateTime Prop152 { get; set; }
        public DateTime Prop153 { get; set; }
        public DateTime Prop154 { get; set; }
        public DateTime Prop155 { get; set; }
        public DateTime Prop156 { get; set; }
        public DateTime Prop157 { get; set; }
        public DateTime Prop158 { get; set; }
        public DateTime Prop159 { get; set; }
        public DateTime Prop160 { get; set; }
        public DateTime Prop161 { get; set; }
        public DateTime Prop162 { get; set; }
        public DateTime Prop163 { get; set; }
        public DateTime Prop164 { get; set; }
        public DateTime Prop165 { get; set; }
        public DateTime Prop166 { get; set; }
        public DateTime Prop167 { get; set; }
        public DateTime Prop168 { get; set; }
        public DateTime Prop169 { get; set; }
        public DateTime Prop170 { get; set; }
        public DateTime Prop171 { get; set; }
        public DateTime Prop172 { get; set; }
        public DateTime Prop173 { get; set; }
        public DateTime Prop174 { get; set; }
        public DateTime Prop175 { get; set; }
        public DateTime Prop176 { get; set; }
        public DateTime Prop177 { get; set; }
        public DateTime Prop178 { get; set; }
        public DateTime Prop179 { get; set; }
        public DateTime Prop180 { get; set; }
        public DateTime Prop181 { get; set; }
        public DateTime Prop182 { get; set; }
        public DateTime Prop183 { get; set; }
        public DateTime Prop184 { get; set; }
        public DateTime Prop185 { get; set; }
        public DateTime Prop186 { get; set; }
        public DateTime Prop187 { get; set; }
        public DateTime Prop188 { get; set; }
        public DateTime Prop189 { get; set; }
        public DateTime Prop190 { get; set; }
        public DateTime Prop191 { get; set; }
        public DateTime Prop192 { get; set; }
        public DateTime Prop193 { get; set; }
        public DateTime Prop194 { get; set; }
        public DateTime Prop195 { get; set; }
        public DateTime Prop196 { get; set; }
        public DateTime Prop197 { get; set; }
        public DateTime Prop198 { get; set; }
        public DateTime Prop199 { get; set; }
        public DateTime Prop200 { get; set; }
    }
}
