package com.cimarasah.nossape.enums;

public enum TipoVariacaoContaEnum {
	ValorFixo(1),
	ValorVariavel(2);

	public int tipo;
	public String tpDescricao;
	TipoVariacaoContaEnum(int tipo) {
		this.tipo = tipo;
	}
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Valor fixo";
			break;
		case 2:
			tpDescricao="Valor variável";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
