package com.cimarasah.nossape.controller;

//import java.util.List;
//
//import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

//import com.cimarasah.nossape.dto.MoradorDTO;
//import com.cimarasah.nossape.service.IMoradorService;

@RestController
public class MoradorController {
	
//	@Autowired
//	private IMoradorService moradorService;

	@RequestMapping(method=RequestMethod.GET, value="/moradores")
	public void buscarMoradores(){
//		List<MoradorDTO> listaMoradores = moradorService.listarTodos();
//		System.out.println(listaMoradores.get(0).getNome());
	}
}
