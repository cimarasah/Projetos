package com.cimarasah.nossape.fachada;

import java.util.List;

import com.cimarasah.nossape.dto.MoradorDTO;

public interface IMoradorFachada {

	List<MoradorDTO> listarMorador();
	
	MoradorDTO buscarMoradorPorId(int id);
	
	List<MoradorDTO> buscarMoradorPorNome(String nome);
	
	void salvarMorador(MoradorDTO morador);
	
	void excluirMorador(int id);
	
	
}
