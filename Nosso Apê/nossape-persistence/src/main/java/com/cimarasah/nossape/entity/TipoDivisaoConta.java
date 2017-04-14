package com.cimarasah.nossape.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="TIPO_DIVISAO_CONTA")
public class TipoDivisaoConta {
	
	@Id()
	private String id;

	@Column(name="DS_DESCRICAO")
	private String descricao;

}
