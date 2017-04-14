package com.cimarasah.nossape.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="TIPO_PERIODICIDADE")
public class TipoPeriodicidade {

	@Id()
	private String id;

	@Column(name="DS_PERIODICIDADE")
	private String periodicidade;
}
