package com.cimarasah.nossape.enums;

public enum TipoMoradorEnum {
	Administrador(1),
	Usuario(2);

	public int tipo;
	public String tpDescricao;
	TipoMoradorEnum(int tipo) {
		this.tipo = tipo;
	}
	public String getTpDescricao(){
		switch (this.tipo) {
		case 1:
			tpDescricao="Administrador";
			break;
		case 2:
			tpDescricao="Usuario";
			break;
		default:
			tpDescricao = null;
			break;
		}
		return tpDescricao;
	}
}
