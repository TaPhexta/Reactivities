import { Box, Container, CssBaseline } from "@mui/material";
import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard";
import NavBar from "./NavBar";
;

function App() {
  

  return (
    <Box sx={{ bgcolor: "lightgrey", minHeight: "100vh" }}>
      <CssBaseline />
      <NavBar />
      <Container maxWidth="xl" sx={{ mt: 3 }}>
        <ActivityDashboard />
      </Container>
    </Box>
  );
}

export default App;
