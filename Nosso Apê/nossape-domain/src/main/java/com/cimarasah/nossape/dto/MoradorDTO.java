package com.cimarasah.nossape.dto;

import java.util.Date;

import com.cimarasah.nossape.enums.TipoMoradorEnum;

public class MoradorDTO {

	private int id;
	private String nome;
	private Date dtNascimento;
	private String telefone;
	private String email;
	private String senha;
	private boolean divideQuarto;
	private double valorPorQuarto;	
	private boolean ativo;
	private int diaLimpeza;
	private TipoMoradorEnum tipoMorador;
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public Date getDtNascimento() {
		return dtNascimento;
	}
	public void setDtNascimento(Date dtNascimento) {
		this.dtNascimento = dtNascimento;
	}
	public String getTelefone() {
		return telefone;
	}
	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getSenha() {
		return senha;
	}
	public void setSenha(String senha) {
		this.senha = senha;
	}
	public boolean isDivideQuarto() {
		return divideQuarto;
	}
	public void setDivideQuarto(boolean divideQuarto) {
		this.divideQuarto = divideQuarto;
	}
	public double getValorPorQuarto() {
		return valorPorQuarto;
	}
	public void setValorPorQuarto(double valorPorQuarto) {
		this.valorPorQuarto = valorPorQuarto;
	}
	public boolean isAtivo() {
		return ativo;
	}
	public void setAtivo(boolean ativo) {
		this.ativo = ativo;
	}
	public int getDiaLimpeza() {
		return diaLimpeza;
	}
	public void setDiaLimpeza(int diaLimpeza) {
		this.diaLimpeza = diaLimpeza;
	}
	public TipoMoradorEnum getTipoMorador() {
		return tipoMorador;
	}
	public void setTipoMorador(TipoMoradorEnum tipoMorador) {
		this.tipoMorador = tipoMorador;
	}
}
