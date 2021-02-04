import React, { Component } from "react";
import "./Dashboard.css";
import { Container, Row, Col } from "react-bootstrap";
import WidgetText from "./WidgetText";
import WidgetBar from "./WidgetBar";
import WidgetDoughnut from "./WidgetDoughnut";
import Dropdown from "react-dropdown";
import "react-dropdown/style.css";

//excel import
const config = {
  apiKey: "AIzaSyDMu-Vw30ykPPmFT3cXeunzKEi4EahzglI",
  spreadsheetId: "1vcDPrMexD8bxNwwzK9IxF8wch6Hfezq2eooJACDiqgg"
};
const url = `https://sheets.googleapis.com/v4/spreadsheets/${config.spreadsheetId}/values:batchGet?ranges=Sheet1&majorDimension=ROWS&key=${config.apiKey}`;

class Dashboard extends Component {
  constructor() {
    super();
    this.state = {
      items: [],
      dropdownOptions: [],
      selectedValue: null,
      organicSource: null,
      directSource: null,
      referralSource: null,
      pageViews: null,
      users: null,
      newUsers: null,
      sourceArr: [],
      usersArr: [],
      oldUsers: null,
      sessions: null,
      totalsources: null,
      sessionsperusers: null,
      sessionarr: [],
      socialsource: null,
      emailsource: null,
      pagepersession: null,
      avgsessiontime: null,
      bouncerate: null,
      sessionpagearr: []
    };
  }

  getData = (arg) => {
    const arr = this.state.items;
    const arrLen = arr.length;
    let organicSource = 0;
    let directSource = 0;
    let referralSource = 0;
    let pageViews = 0;
    let users = 0;
    let newUsers = 0;
    let oldUsers = 0;
    let sessions = 0;
    let totalsources = 0;
    let sessionsperusers = 0;
    let emailsource = 0;
    let socialsource = 0;
    let pagepersession = 0;
    let avgsessiontime = 0;
    let bouncerate = 0;
    let selectedValue = null;
    let sourceArr = [];
    let usersArr = [];
    let sessionarr = [];
    let sessionpagearr = [];
    for (let i = 0; i < arrLen; i++) {
      if (arg == arr[i]["month"]) {
        organicSource = arr[i].organic_source;
        directSource = arr[i].direct_source;
        referralSource = arr[i].referral_source;
        pageViews = arr[i].page_views;
        users = arr[i].users;
        newUsers = arr[i].new_users;
        sessions = arr[i].sessions;
        sessionsperusers = arr[i].number_of_sessions_per_users;
        emailsource = arr[i].email_source;
        socialsource = arr[i].social_source;
        pagepersession = arr[i].page_per_session;
        avgsessiontime = arr[i].avg_session_time;
        bouncerate = arr[i].bounce_rate;
        sessionpagearr.push(
          {
            label: "Page Views",
            value: arr[i].page_views
          },
          {
            label: "Sessions",
            value: arr[i].sessions
          },
          {
            label: "Page per session",
            value: arr[i].page_per_session
          }
        );
        sessionarr.push(
          {
            label: "Users",
            value: arr[i].users
          },
          {
            label: "No. of Sessions per Users",
            value: arr[i].number_of_sessions_per_users
          }
        );
        sourceArr.push(
          {
            label: "Organic Source",
            value: arr[i].organic_source
          },
          {
            label: "Direct Source",
            value: arr[i].direct_source
          },
          {
            label: "Referral Source",
            value: arr[i].referral_source
          }
        );
        usersArr.push(
          {
            label: "Users",
            value: arr[i].users
          },
          {
            label: "New Users",
            value: arr[i].new_users
          }
        );
        oldUsers = users - newUsers;
        totalsources =
          parseInt(organicSource) +
          parseInt(directSource) +
          parseInt(referralSource) +
          parseInt(emailsource) +
          parseInt(socialsource);
      }
      selectedValue = arg;
      this.setState(
        {
          organicSource: organicSource,
          directSource: directSource,
          referralSource: referralSource,
          pageViews: pageViews,
          users: users,
          newUsers: newUsers,
          sourceArr: sourceArr,
          usersArr: usersArr,
          oldUsers: oldUsers,
          sessions: sessions,
          totalsources: totalsources,
          sessionsperusers: sessionsperusers,
          sessionarr: sessionarr,
          emailsource: emailsource,
          socialsource: socialsource,
          pagepersession: pagepersession,
          sessionpagearr: sessionpagearr,
          bouncerate: bouncerate,
          avgsessiontime: avgsessiontime
        },
        () => {
          console.log(this.state.organicSource);
        }
      );
    }
  };
  updateDashboard = (event) => {
    this.getData(event.value);
    this.setState({ selectedValue: event.value }, () => {
      console.log(this.state.organicSource);
    });
  };

  componentDidMount() {
    fetch(url)
      .then((response) => response.json())
      .then((data) => {
        let batchRowValues = data.valueRanges[0].values;

        const rows = [];

        for (let i = 1; i < batchRowValues.length; i++) {
          let rowObject = {};
          for (let j = 0; j < batchRowValues[i].length; j++) {
            rowObject[batchRowValues[0][j]] = batchRowValues[i][j];
          }
          rows.push(rowObject);
        }
        let dropdownOptions = [];

        for (let i = 0; i < rows.length; i++) {
          dropdownOptions.push(rows[i].month);
        }

        dropdownOptions = Array.from(new Set(dropdownOptions)).reverse();
        this.setState(
          {
            items: rows,
            dropdownOptions: dropdownOptions,
            selectedValue: "Jan 2018"
          },
          () => this.getData("Jan 2018")
        );
      });
  }

  render() {
    /*const chartConfigs = {
      type: "bar2d", // The chart type
      width: "100%", // Width of the chart
      height: "125", // Height of the chart
      dataFormat: "json", // Data type
      dataSource: {
        // Chart Configuration
        chart: {
          bgcolor: "#2a2a2a",
          theme: "fusion" //Set the theme for your chart
        },
        // Chart Data - from step 2
        data: chartData
      }
    };*/

    return (
      <div>
        <Container fluid>
          <Row className="topHeader">
            <Col></Col>
            <Col>
              <Dropdown
                options={this.state.dropdownOptions}
                onChange={this.updateDashboard}
                value={this.state.selectedValue}
                placeholder="Select an option"
              />
            </Col>
          </Row>
        </Container>
        <Container className="mainDashboard">
          <Row>
            <Col>
              <WidgetText
                title="Organic Source"
                value={this.state.organicSource}
              />
            </Col>
            <Col>
              <WidgetText
                title="Direct Source"
                value={this.state.directSource}
              />
            </Col>
            <Col>
              <WidgetText
                title="Referral Source"
                value={this.state.referralSource}
              />
            </Col>
            <Col>
              <WidgetText
                title="Social Source"
                value={this.state.socialsource}
              />
            </Col>
            <Col>
              <WidgetText title="Email Source" value={this.state.emailsource} />
            </Col>
            <Col>
              <WidgetText
                title="Total SourceS"
                value={this.state.totalsources}
              />
            </Col>
          </Row>
          <Row>
            <Col>
              <WidgetBar
                title="Organic, Direct and Referral Source Comparision"
                data={this.state.sourceArr}
              />
            </Col>

            <Col>
              <WidgetDoughnut
                title="Users Comparision"
                data={this.state.usersArr}
              />
            </Col>
          </Row>
        </Container>
        <Container className="mainDashboard">
          <Row>
            <Col>
              <WidgetText title="Users" value={this.state.users} />
            </Col>
            <Col>
              <WidgetText title="New Users" value={this.state.newUsers} />
            </Col>
            <Col>
              <WidgetText title="Old Users" value={this.state.oldUsers} />
            </Col>
            <Col>
              <WidgetText title="Sessions" value={this.state.sessions} />
            </Col>
            <Col>
              <WidgetText title="Page Views" value={this.state.pageViews} />
            </Col>
            <Col>
              <WidgetText
                title="Page per session"
                value={this.state.pagepersession}
              />
            </Col>
          </Row>
        </Container>
        <Container className="mainDashboard">
          <Row>
            <Col>
              <WidgetText
                title="Sessions per users"
                value={this.state.sessionsperusers}
              />
            </Col>
            <Col>
              <WidgetText
                title="Average Session Time"
                value={this.state.avgsessiontime}
              />
            </Col>
            <Col>
              <WidgetText title="Bounce Rate" value={this.state.bouncerate} />
            </Col>
          </Row>
          <Row>
            <Col>
              <WidgetDoughnut
                title="Sessions, users analysis"
                data={this.state.sessionarr}
              />
            </Col>
          </Row>
          <Row>
            <Col>
              <WidgetBar
                title="Sessions, Page analysis"
                data={this.state.sessionpagearr}
              />
            </Col>
          </Row>
        </Container>
      </div>
    );
  }
}

export default Dashboard;
