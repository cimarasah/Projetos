package com.cimarasah.nossape.entity;


import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

/**
 * @author Cimara Sá
 *
 */
@Entity
@Table(name="CRONOGRAMA")
public class Cronograma {

	@Id()
	private int id;

	@Column(name="MES_ANO")
	private int mesAno;
	
	@OneToMany(targetEntity=Evento.class, mappedBy="cronograma")
	private Set<Evento> eventos;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getMesAno() {
		return mesAno;
	}

	public void setMesAno(int mesAno) {
		this.mesAno = mesAno;
	}

	public Set<Evento> getEventos() {
		return eventos;
	}

	public void setEventos(Set<Evento> eventos) {
		this.eventos = eventos;
	}
}
