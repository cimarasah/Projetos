package com.cimarasah.nossape.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name="DEBITO_PESSOAL_MENSAL")
public class DebitoPessoalMensal {

	@Id()
	private int id;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CONTA_FINAL", nullable=false)
	private ContaFinalMensal contaFinal;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_MORADOR", nullable=false)
	private Morador morador;
	
	@Column(name="VL_MENSAL")
	private double vlMensal;
	
	@Column(name="FL_PAGO")
	private boolean pago;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public ContaFinalMensal getContaFinal() {
		return contaFinal;
	}

	public void setContaFinal(ContaFinalMensal contaFinal) {
		this.contaFinal = contaFinal;
	}

	public Morador getMorador() {
		return morador;
	}

	public void setMorador(Morador morador) {
		this.morador = morador;
	}

	public double getVlMensal() {
		return vlMensal;
	}

	public void setVlMensal(double vlMensal) {
		this.vlMensal = vlMensal;
	}

	public boolean isPago() {
		return pago;
	}

	public void setPago(boolean pago) {
		this.pago = pago;
	}
}
