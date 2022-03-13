import './App.css'
import { Message } from './components/Message'
import { Map } from './components/Map'
import { MapSetting } from './components/MapSetting'
import { LoadingBar } from './components/LoadingBar'

function App() {
  return (
    <main className="App">
        <div className="content">
          <Map/>
          <MapSetting/>
        </div>
        <Message/>
        <LoadingBar/>
    </main>
  )
}

export default App
