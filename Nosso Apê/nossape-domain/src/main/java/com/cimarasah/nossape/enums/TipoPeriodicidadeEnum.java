package com.cimarasah.nossape.enums;

public enum TipoPeriodicidadeEnum {
	Diaria(1),
	Semanal(2),
	Mensal(3);

	public int tipo;
	public String tpDescricao;
	TipoPeriodicidadeEnum(int tipo) {
		this.tipo = tipo;
	}
	
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Diaria";
			break;
		case 2:
			tpDescricao="Semanal";
			break;	
		case 3:
			tpDescricao="Mensal";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
