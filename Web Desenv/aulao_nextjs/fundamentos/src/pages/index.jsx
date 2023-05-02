import Navegador from "../components/Navegador"

export default function Inicio() {
  return (
    <div style={{
          display: 'flex',
          justifyContent:'center',
          alignItems: 'center',
          flexWrap: 'wrap',
          height: '100vh'

    }}>
        <Navegador texto ="Estiloso" destino="/estiloso" cor="#ff0045"/>
        <Navegador texto ="Exemplo"  destino="/exemplo"  cor="chocolate"/>
        <Navegador texto ="Jsx" destino="/jsx" cor="#159915" />
        <Navegador texto ="Navegação #01" destino="/navegacao/"cor="#331165" />
        <Navegador texto ="Navegação #02" destino="/cliente/sp/323"cor="#009f5f" />
        <Navegador texto ="Componente com Estado" destino="/estado"cor="#005490" />
        <Navegador texto ="Integração com API #01" destino="/integracao_1"cor="#ff00ff" />
        <Navegador texto ="Conteúdo Estático" destino ="/estatico" cor="#ff0004" />

    </div>
  )
}