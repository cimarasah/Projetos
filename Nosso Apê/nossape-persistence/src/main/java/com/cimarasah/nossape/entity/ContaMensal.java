package com.cimarasah.nossape.entity;

import java.sql.Date;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

/**
 * @author Cimara Sá
 *
 */
@Entity
@Table(name="CONTA_MENSAL")
public class ContaMensal {

	@Id()
	private int id;

	@ManyToOne()
	@JoinColumn(name="FK_ID_CONTA_FINAL", nullable=false)
	private ContaFinalMensal contaFinal;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CONTA", nullable=false)
	private Conta conta;
	
	@Column(name="VL_MES_ATUAL")
	private double vlMesAtual;
	
	@Column(name="DT_PAGAMENTO")
	private Date dtPagamento;
	
	@Column(name="FL_PAGO")
	private boolean pago;

	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="contaMensal")
	private Set<PagamentoConta> pagamentosContas;

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

	public Conta getConta() {
		return conta;
	}

	public void setConta(Conta conta) {
		this.conta = conta;
	}

	public double getVlMesAtual() {
		return vlMesAtual;
	}

	public void setVlMesAtual(double vlMesAtual) {
		this.vlMesAtual = vlMesAtual;
	}

	public Date getDtPagamento() {
		return dtPagamento;
	}

	public void setDtPagamento(Date dtPagamento) {
		this.dtPagamento = dtPagamento;
	}

	public boolean isPago() {
		return pago;
	}

	public void setPago(boolean pago) {
		this.pago = pago;
	}

	public Set<PagamentoConta> getPagamentosContas() {
		return pagamentosContas;
	}

	public void setPagamentosContas(Set<PagamentoConta> pagamentosContas) {
		this.pagamentosContas = pagamentosContas;
	}
}
