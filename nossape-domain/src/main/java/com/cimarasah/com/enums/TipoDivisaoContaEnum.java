package com.cimarasah.com.enums;

public enum TipoDivisaoContaEnum {
	PorMorador(1),
	PorQuarto(2);

	public int tipo;
	public String tpDescricao;
	TipoDivisaoContaEnum(int tipo) {
		this.tipo = tipo;
	}
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Por morador";
			break;
		case 2:
			tpDescricao="Por quarto";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
