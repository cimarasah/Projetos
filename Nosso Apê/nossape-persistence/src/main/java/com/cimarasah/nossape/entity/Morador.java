package com.cimarasah.nossape.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="MORADOR")
public class Morador {

	@Id()	
	private String id;

	@Column(name="DS_NOME")
	private String NOME;
	
//	@Column(name="DS_NOME")
//	private String NOME;
//
//	@Column(name="DS_NOME")
//	private String NOME;
//	
//	@Column(name="DS_NOME")
//	private String NOME;
}
