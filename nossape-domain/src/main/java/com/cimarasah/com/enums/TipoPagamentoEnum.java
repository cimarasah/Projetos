package com.cimarasah.com.enums;

public enum TipoPagamentoEnum {
	Total(1),
	Parcial(2);

	public int tipo;
	public String tpDescricao;
	TipoPagamentoEnum(int tipo) {
		this.tipo = tipo;
	}
	
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Total";
			break;
		case 2:
			tpDescricao="Parcial";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
