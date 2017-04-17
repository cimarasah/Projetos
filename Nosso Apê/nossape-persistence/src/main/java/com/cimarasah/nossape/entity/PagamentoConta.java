package com.cimarasah.nossape.entity;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 * @author Cimara Sá
 *
 */
@Entity
@Table(name="PAGAMENTO_CONTA")
public class PagamentoConta {

	@Id()
	private int id;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CONTA_MENSAL", nullable=false)
	private ContaMensal contaMensal;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_PAGAMENTO", nullable=false)
	private TipoPagamento tipoPagamento;
	
	@Column(name="VL_CONTA")
	private double vlConta;
	
	@Column(name="DT_PAGAMENTO")
	private Date dtPagamento;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_MORADOR", nullable=false)
	private Morador morador;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CAIXINHAL", nullable=false)
	private Caixinha caixinha;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public ContaMensal getContaMensal() {
		return contaMensal;
	}

	public void setContaMensal(ContaMensal contaMensal) {
		this.contaMensal = contaMensal;
	}

	public TipoPagamento getTipoPagamento() {
		return tipoPagamento;
	}

	public void setTipoPagamento(TipoPagamento tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}

	public double getVlConta() {
		return vlConta;
	}

	public void setVlConta(double vlConta) {
		this.vlConta = vlConta;
	}

	public Date getDtPagamento() {
		return dtPagamento;
	}

	public void setDtPagamento(Date dtPagamento) {
		this.dtPagamento = dtPagamento;
	}

	public Morador getMorador() {
		return morador;
	}

	public void setMorador(Morador morador) {
		this.morador = morador;
	}

	public Caixinha getCaixinha() {
		return caixinha;
	}

	public void setCaixinha(Caixinha caixinha) {
		this.caixinha = caixinha;
	}
}
