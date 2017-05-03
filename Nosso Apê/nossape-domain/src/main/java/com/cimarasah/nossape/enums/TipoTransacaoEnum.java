package com.cimarasah.nossape.enums;

public enum TipoTransacaoEnum {
	Positivo(1),
	Negativo(2);

	public int tipo;
	public String tpDescricao;
	TipoTransacaoEnum(int tipo) {
		this.tipo = tipo;
	}
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Positivo";
			break;
		case 2:
			tpDescricao="Negativo";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
