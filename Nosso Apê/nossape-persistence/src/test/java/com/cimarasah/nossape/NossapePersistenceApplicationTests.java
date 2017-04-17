package com.cimarasah.nossape;

import static org.junit.Assert.assertTrue;

import java.util.List;

import org.apache.log4j.Logger;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import com.cimarasah.nossape.entity.Morador;
import com.cimarasah.nossape.repository.IMoradorRepository;




@RunWith(SpringRunner.class)
@SpringBootTest
public class NossapePersistenceApplicationTests {

	@Autowired
	IMoradorRepository moradorRepository;
	Logger log = Logger.getLogger(this.getClass());	
	@Test
	public void contextLoads() {
	}

	@Test
	public void ListaMoradoresOK(){
		try {
			log.info("Listar moradores");
			List<Morador> moradores = moradorRepository.findAll();
			
			assertTrue(moradores.size()>0);
			log.info("Listar moradores OK");
		} catch (Exception e) {
			// TODO: handle exceptionlog.info("Listar moradores");
			log.error("Erro ao listar moradores: "+e.getMessage());
			
		}
		
	}
}
