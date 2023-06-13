﻿using App_BancoDigital.Model;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace App_BancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        /**
         * Realiza o login do cliente.
         * 
         * Recebe um objeto Correntista como parâmetro e retorna uma 
         * tarefa (Task) que representa a execução assíncrona do 
         * método. A tarefa resultará em um objeto Correntista.
         * 
         * Em resumo, esse código recebe um objeto Correntista, 
         * serializa-o para JSON, envia essa string JSON para um 
         * serviço/API de login e recebe uma resposta JSON. 
         * Em seguida, a resposta é desserializada de volta para 
         * um objeto Correntista, que é retornado como resultado
         * da tarefa assíncrona.
         */
        public static async Task<Correntista> LoginAsync(Correntista c)
        {
            /**
             *  Nesta linha, o objeto Correntista fornecido é 
             *  serializado para uma representação JSON usando o 
             *  método SerializeObject da classe JsonConvert. 
             *  Isso converte o objeto c em uma string JSON.
             */
            var json_a_enviar = JsonConvert.SerializeObject(c);

            /**
             * há uma chamada assíncrona para um método chamado 
             * PostDataToService do serviço DataService. O método 
             * PostDataToService envia a string JSON serializada 
             * para um serviço/API, especificado pelo caminho 
             * "/correntista/entrar". A resposta do serviço é 
             * uma string JSON, que é armazenada na variável
             * json. O await aguarda a conclusão da operação 
             * assíncrona antes de prosseguir para a próxima 
             * linha de código.
             */
            string json = await DataService.PostDataToService(json_a_enviar, 
                "/correntista/entrar");

            /**
             * Nesta linha, a string JSON recebida é desserializada 
             * usando o método DeserializeObject da classe JsonConvert. 
             * Ela é convertida de volta para um objeto Correntista e 
             * retornado como resultado da tarefa.
             */
            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        /**
         * Envia a Model de um Cliente para ser cadastrado no banco.
         * 
         *  que recebe um objeto Correntista como parâmetro e retorna 
         *  uma tarefa (Task) que representa a execução assíncrona do 
         *  método. A tarefa resultará em um objeto Correntista.
         */
        public static async Task<Correntista> SaveAsync(Correntista c)
        {
            /**
             * Nesta linha, o objeto Correntista fornecido é serializado 
             * para uma representação JSON usando o método SerializeObject 
             * da classe JsonConvert. Isso converte o objeto c em uma 
             * string JSON.
             * 
             * Em resumo, esse código recebe um objeto Correntista, 
             * serializa-o para JSON, envia essa string JSON para 
             * um serviço/API de salvamento especificado, recebe uma 
             * resposta JSON contendo os dados atualizados do Correntista 
             * e desserializa essa resposta de volta para um objeto 
             * Correntista, que é retornado como resultado da tarefa assíncrona.
             */
            var json_a_enviar = JsonConvert.SerializeObject(c);

            /**
             * Nesta linha, há uma chamada assíncrona para um método 
             * chamado PostDataToService do serviço DataService. O 
             * método PostDataToService envia a string JSON serializada 
             * para um serviço/API, especificado pelo caminho 
             * "/correntista/salvar", com a finalidade de salvar o 
             * objeto Correntista. A resposta do serviço é uma string 
             * JSON, que é armazenada na variável json. O await aguarda 
             * a conclusão da operação assíncrona antes de prosseguir 
             * para a próxima linha de código.
             */
            string json = await DataService.PostDataToService
                (json_a_enviar, "/correntista/salvar");

            /**
             * Nesta linha, a string JSON recebida é desserializada 
             * usando o método DeserializeObject da classe JsonConvert.
             * Ela é convertida de volta para um objeto Correntista e 
             * retornado como resultado da tarefa.
             */
            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }
}
